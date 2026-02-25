namespace System.Threading.Tasks;

[FriendAccessAllowed]
[Token(Token = "0x2000284")]
internal enum AsyncCausalityStatus
{
	Started = 0,
	Completed = 1,
	Canceled = 2,
	Error = 3,
}

