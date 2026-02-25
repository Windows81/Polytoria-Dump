namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Position As UV1", 82)]
[Token(Token = "0x2000087")]
public class PositionAsUV1 : BaseMeshEffect
{

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000541")]
	protected PositionAsUV1() { }

	[Address(RVA = "0x1CC9540", Offset = "0x1CC8740", Length = "0x2A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000542")]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

