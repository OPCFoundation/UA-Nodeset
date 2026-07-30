/* ========================================================================
 * Copyright (c) 2005-2026, OPC Federation AISBL, All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/
namespace Opc.Ua.WebApi
{
    /// <summary>
    /// The well known identifiers for Attributes.
    /// </summary>
    public static class Attributes
    {
        /// <remarks />
        public const long NodeId = 1;
        /// <remarks />
        public const long NodeClass = 2;
        /// <remarks />
        public const long BrowseName = 3;
        /// <remarks />
        public const long DisplayName = 4;
        /// <remarks />
        public const long Description = 5;
        /// <remarks />
        public const long WriteMask = 6;
        /// <remarks />
        public const long UserWriteMask = 7;
        /// <remarks />
        public const long IsAbstract = 8;
        /// <remarks />
        public const long Symmetric = 9;
        /// <remarks />
        public const long InverseName = 10;
        /// <remarks />
        public const long ContainsNoLoops = 11;
        /// <remarks />
        public const long EventNotifier = 12;
        /// <remarks />
        public const long Value = 13;
        /// <remarks />
        public const long DataType = 14;
        /// <remarks />
        public const long ValueRank = 15;
        /// <remarks />
        public const long ArrayDimensions = 16;
        /// <remarks />
        public const long AccessLevel = 17;
        /// <remarks />
        public const long UserAccessLevel = 18;
        /// <remarks />
        public const long MinimumSamplingInterval = 19;
        /// <remarks />
        public const long Historizing = 20;
        /// <remarks />
        public const long Executable = 21;
        /// <remarks />
        public const long UserExecutable = 22;
        /// <remarks />
        public const long DataTypeDefinition = 23;
        /// <remarks />
        public const long RolePermissions = 24;
        /// <remarks />
        public const long UserRolePermissions = 25;
        /// <remarks />
        public const long AccessRestrictions = 26;
        /// <remarks />
        public const long AccessLevelEx = 27;

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(long value)
        {
            foreach (var field in typeof(Attributes).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }
    
}
