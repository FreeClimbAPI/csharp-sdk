using Newtonsoft.Json;
using System;

namespace com.freeclimb.api
{
    /// <summary>
    /// FreeClimbCommon is the base class from which all classes that are built to
    /// represent objects returned from the FreeClimb API are built upon. A user
    /// of the SDK should never directly interact with a FreeClimbCommon object.
    /// </summary>
    [JsonObject]
    public class FreeClimbCommon : IFreeClimbCommon, IEquatable<FreeClimbCommon>
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "uri")]
        private readonly string uri;

        [JsonProperty(PropertyName = "dateCreated")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime dateCreated;

        [JsonProperty(PropertyName = "dateUpdated")]
        [JsonConverter(typeof(DateTimeConverter))]
        private readonly DateTime dateUpdated;

        [JsonProperty(PropertyName = "revision")]
        private readonly int revision;
#pragma warning restore 0649

        /// <summary>
        /// Retrieve  URI where this resource can be found.
        /// </summary>
        /// <returns>URI where this resource can be found.</returns>
        public string getUri { get { return this.uri; } }

        /// <summary>
        /// Retrieve  Time and date when this resource was created.
        /// </summary>
        /// <returns>Time and date when this resource was created.</returns>
        public DateTime getDateCreated { get { return this.dateCreated; } }

        /// <summary>
        /// Retrieve  Time and date when this resource was last updated.
        /// </summary>
        /// <returns>Time and date when this resource was last updated.</returns>
        public DateTime getDateUpdated { get { return this.dateUpdated; } }

        /// <summary>
        /// Retrieve  the number of revisions this object has undergone.
        /// </summary>
        /// <returns>The number of revisions this object has undergone.</returns>
        public int getRevision { get { return this.revision; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.dateCreated.GetHashCode();
            hash ^= this.dateUpdated.GetHashCode();
            hash ^= this.revision.GetHashCode();
            hash ^= this.uri.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type FreeClimbCommon.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            FreeClimbCommon b = obj as FreeClimbCommon;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// FreeClimbCommon equality operator.
        /// </summary>
        /// <param name="a">FreeClimbCommon object.</param>
        /// <param name="b">FreeClimbCommon object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(FreeClimbCommon a, FreeClimbCommon b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// FreeClimbCommon inequality operator.
        /// </summary>
        /// <param name="a">FreeClimbCommon object.</param>
        /// <param name="b">FreeClimbCommon object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(FreeClimbCommon a, FreeClimbCommon b)
        {
            return !(a == b);
        }

        /// <summary>
	    /// Helper method to deep compare two FreeClimbCommon instances.
        /// </summary>
        /// <param name="a">FreeClimbCommon instance one.</param>
        /// <param name="b">FreeClimbCommon instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(FreeClimbCommon a, FreeClimbCommon b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return String.Equals(a.getUri, b.getUri, StringComparison.Ordinal) &&
                   ((DateTime.Compare(a.getDateCreated,b.getDateCreated) == 0) ? true : false) &&
                   ((DateTime.Compare(a.getDateUpdated, b.getDateUpdated) == 0) ? true : false) &&
                   (a.getRevision == b.getRevision);
        }

        /// <summary>
        /// Compares the current instance with another FreeClimbCommon object.
        /// </summary>
        /// <param name="other">FreeClimbCommon object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(FreeClimbCommon other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }
    }
}
