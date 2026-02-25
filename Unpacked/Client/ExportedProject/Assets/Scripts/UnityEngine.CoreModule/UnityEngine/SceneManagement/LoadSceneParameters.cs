namespace UnityEngine.SceneManagement;

[Token(Token = "0x20001E7")]
public struct LoadSceneParameters
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000690")]
	private LoadSceneMode m_LoadSceneMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000691")]
	private LocalPhysicsMode m_LocalPhysicsMode; //Field offset: 0x4

	[Address(RVA = "0xF6A340", Offset = "0xF69540", Length = "0xA")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC9")]
	public LoadSceneParameters(LoadSceneMode mode) { }

}

