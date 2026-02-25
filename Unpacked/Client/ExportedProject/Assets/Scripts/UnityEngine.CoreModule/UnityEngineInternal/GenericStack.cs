namespace UnityEngineInternal;

[Token(Token = "0x2000008")]
public class GenericStack : Stack
{

	[Address(RVA = "0x192A260", Offset = "0x1929460", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.GUI", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000008")]
	public GenericStack() { }

}

