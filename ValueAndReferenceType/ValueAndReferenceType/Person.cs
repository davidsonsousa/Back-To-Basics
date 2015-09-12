using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
	/// <summary>
	/// Class is reference type
	/// </summary>
	class PersonClass
	{
		public string GivenName { get; set; }
		public string Surname { get; set; }
		public string FullName
		{
			get
			{
				return string.Format("{0} {1}", this.GivenName, this.Surname);
			}
		}
	}

	/// <summary>
	/// Struct is value type
	/// </summary>
	struct PersonStruct
	{
		public string GivenName { get; set; }
		public string Surname { get; set; }
		public string FullName
		{
			get
			{
				return string.Format("{0} {1}", this.GivenName, this.Surname);
			}
		}
	}
}
