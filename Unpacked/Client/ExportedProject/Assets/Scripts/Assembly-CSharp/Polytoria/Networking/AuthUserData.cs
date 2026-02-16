namespace Polytoria.Networking
{
	public struct AuthUserData
	{
		public int ID { get; set; }

		public string Username { get; set; }

		public string Token { get; set; }

		public bool CanChat { get; set; }

		public bool IsAgeRestricted { get; set; }

		public AuthUserData(int id, string username, string token, bool canChat, bool isAgeRestricted)
		{
			ID = 0;
			Username = null;
			Token = null;
			CanChat = false;
			IsAgeRestricted = false;
		}
	}
}
