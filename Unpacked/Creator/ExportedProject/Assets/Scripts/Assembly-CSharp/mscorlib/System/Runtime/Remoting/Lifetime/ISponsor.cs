namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x200035B")]
public interface ISponsor
{

	[Token(Token = "0x6001AC6")]
	public TimeSpan Renewal(ILease lease) { }

}

