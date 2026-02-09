namespace Polytoria.Controllers
{
	public struct ImageCacheKey
	{
		public string id;

		public string url;

		public ImageType type;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
