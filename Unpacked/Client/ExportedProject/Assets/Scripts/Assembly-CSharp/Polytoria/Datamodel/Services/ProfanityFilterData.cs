using System;

namespace Polytoria.Datamodel.Services
{
	[Serializable]
	public class ProfanityFilterData
	{
		public int id;

		public string content;

		public bool isRegex;
	}
}
