namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x200035A")]
public interface ILease
{

	[Token(Token = "0x170002E6")]
	public TimeSpan CurrentLeaseTime
	{
		[Token(Token = "0x6001AC2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E7")]
	public LeaseState CurrentState
	{
		[Token(Token = "0x6001AC3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E8")]
	public TimeSpan RenewOnCallTime
	{
		[Token(Token = "0x6001AC4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001AC2")]
	public TimeSpan get_CurrentLeaseTime() { }

	[Token(Token = "0x6001AC3")]
	public LeaseState get_CurrentState() { }

	[Token(Token = "0x6001AC4")]
	public TimeSpan get_RenewOnCallTime() { }

	[Token(Token = "0x6001AC5")]
	public TimeSpan Renew(TimeSpan renewalTime) { }

}

