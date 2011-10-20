using System;

namespace FindDuplicateMp3s
{
  [Flags]
  internal enum CompareFileds
  {
    None = 0x0,
    FileName = 0x1,
    Title = 0x2,
    Length = 0x4,
    Size = 0x8,
    Artist = 0x10,
    Identical = 0x20
  }


  internal class Track : IEquatable<Track>
  {
    public static CompareFileds CompareFileds { get; set; }

    public static bool MatchAllConditions { get; set; }

    public string FileName { get; set; }

    public string Path { get; set; }

    public string Artist { get; set; }

    public string Title { get; set; }

    public string Album { get; set; }

    public string Year { get; set; }

    public string Genre { get; set; }

    public TimeSpan Length { get; set; }

    public long? Size { get; set; }

    #region IEquatable<Track> Members

    /// <summary>
    ///   Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <returns>
    ///   true if the current object is equal to the <paramref name = "other" /> parameter; otherwise, false.
    /// </returns>
    /// <param name = "other">An object to compare with this object.</param>
    public bool Equals(Track other)
    {
      if (ReferenceEquals(null, other))
      {
        return false;
      }
      if (ReferenceEquals(this, other))
      {
        return true;
      }

      bool titleEq = !string.IsNullOrWhiteSpace(Title) && Equals(other.Title, Title);
      bool artistEq = !string.IsNullOrWhiteSpace(Artist) && Equals(other.Artist, Artist);
      bool lengthEq = Length.Ticks != 0 && other.Length.Equals(Length);
      bool sizeEq = Size != 0 && other.Size.Equals(Size);
      bool fileNameEq = Equals(other.FileName, FileName);

      // Find identicle files
      if ((CompareFileds & CompareFileds.Identical) == CompareFileds.Identical)
      {
        return fileNameEq && titleEq && artistEq && lengthEq && sizeEq;
      }

      // Find simulare files
      if( MatchAllConditions )
      {
        titleEq = ( CompareFileds & CompareFileds.Title ) != CompareFileds.Title || titleEq;
        artistEq = ( CompareFileds & CompareFileds.Artist ) != CompareFileds.Artist || artistEq;
        lengthEq = ( CompareFileds & CompareFileds.Length ) != CompareFileds.Length || lengthEq;
        sizeEq = ( CompareFileds & CompareFileds.Size ) != CompareFileds.Size || sizeEq;
        fileNameEq = ( CompareFileds & CompareFileds.FileName ) != CompareFileds.FileName || fileNameEq;
        return fileNameEq && titleEq && artistEq && lengthEq && sizeEq;
      }
      
      titleEq = ( CompareFileds & CompareFileds.Title ) == CompareFileds.Title && titleEq;
      artistEq = ( CompareFileds & CompareFileds.Artist ) == CompareFileds.Artist && artistEq;
      lengthEq = ( CompareFileds & CompareFileds.Length ) == CompareFileds.Length && lengthEq;
      sizeEq = ( CompareFileds & CompareFileds.Size ) == CompareFileds.Size && sizeEq;
      fileNameEq = ( CompareFileds & CompareFileds.FileName ) == CompareFileds.FileName && fileNameEq;
      return fileNameEq || (titleEq && artistEq) || lengthEq || sizeEq;
    }

    #endregion

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj))
      {
        return false;
      }
      if (ReferenceEquals(this, obj))
      {
        return true;
      }
      if (obj.GetType() != typeof (Track))
      {
        return false;
      }
      return Equals((Track) obj);
    }

    /// <summary>
    ///   Serves as a hash function for a particular type.
    /// </summary>
    /// <returns>
    ///   A hash code for the current <see cref = "T:System.Object" />.
    /// </returns>
    /// <filterpriority>2</filterpriority>
    public override int GetHashCode()
    {
      unchecked
      {
        int result = (FileName != null ? FileName.GetHashCode() : 0);
        result = (result*397) ^ (Artist != null ? Artist.GetHashCode() : 0);
        result = (result*397) ^ (Title != null ? Title.GetHashCode() : 0);
        result = (result*397) ^ (Album != null ? Album.GetHashCode() : 0);
        result = (result*397) ^ (Year != null ? Year.GetHashCode() : 0);
        result = (result*397) ^ (Genre != null ? Genre.GetHashCode() : 0);
        result = (result*397) ^ (Length.GetHashCode());
        result = (result*397) ^ (Size.HasValue ? Size.Value.GetHashCode() : 0);
        return result;
      }
    }

    public static bool operator ==(Track left, Track right)
    {
      return Equals(left, right);
    }

    public static bool operator !=(Track left, Track right)
    {
      return !Equals(left, right);
    }
  }
}