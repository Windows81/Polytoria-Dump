namespace UnityEngine.Pool;

[Token(Token = "0x2000280")]
public interface IObjectPool
{

	[Token(Token = "0x6000CE1")]
	public void Release(T element) { }

}

