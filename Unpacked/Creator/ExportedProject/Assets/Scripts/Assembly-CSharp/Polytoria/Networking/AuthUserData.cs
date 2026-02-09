namespace Polytoria.Networking
{
	public struct AuthUserData
	{
		public int ID { get; set; }

		public string Username { get; set; }

		public string Token { get; set; }

		public AuthUserData(int id, string username, string token)
		{
			ID = 0;
			Username = null;
			Token = null;
		}
	}
}
