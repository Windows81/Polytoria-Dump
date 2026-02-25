namespace System.Net;

[Token(Token = "0x2000213")]
internal enum FtpLoginState
{
	NotLoggedIn = 0,
	LoggedIn = 1,
	LoggedInButNeedsRelogin = 2,
	ReloginFailed = 3,
}

