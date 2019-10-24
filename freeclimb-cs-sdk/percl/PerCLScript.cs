using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// The PerCLScript class represents a PerCL script to be returned to the FreeClimb
    /// servers in FreeClimb applications. PerCLScript is a List of PerCLCommands.
    /// </summary>
    public class PerCLScript : List<PerCLCommand>
    {
        /// <summary>
        /// Initializes an empty script.
        /// </summary>
        public PerCLScript() : base() {
        }

        /// <summary>
        /// Converts the script into a JSON array of the contained PerCL commands.
        /// </summary>
        /// <returns>
        /// JSON string array
        /// </returns>
        /// <see cref = "Newtonsoft.Json" />
        /// <exception cref="FreeClimbJSONException">Thrown upon failed request.</exception>
        public string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                List<object> list = new List<object>();
                foreach (PerCLCommand command in this.ToList<PerCLCommand>())
                {
                    list.Add(command.toKvp());
                }

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), list);

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Returns number of elements in list.
        /// </summary>
        /// <returns>
        /// Integer value of list elements.
        /// </returns>
        public int size()
        {
            return this.Count;
        }

        /// <summary>
        /// Retrieves ith list element
        /// </summary>
        /// <param name="idx">Element index.</param>
        /// <returns>
        /// PerCL based command.
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public PerCLCommand get(int idx)
        {
            try
            { 
                return this.ElementAtOrDefault(idx);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }
    }
}
