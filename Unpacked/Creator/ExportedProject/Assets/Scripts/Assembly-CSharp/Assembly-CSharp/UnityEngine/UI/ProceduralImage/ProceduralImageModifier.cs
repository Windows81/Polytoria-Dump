namespace UnityEngine.UI.ProceduralImage;

[DisallowMultipleComponent]
[Token(Token = "0x200044A")]
public abstract class ProceduralImageModifier : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001241")]
	protected Graphic graphic; //Field offset: 0x20

	[Token(Token = "0x17000D30")]
	protected Graphic _Graphic
	{
		[Address(RVA = "0x4F6400", Offset = "0x4F5600", Length = "0x8D")]
		[CalledBy(Type = typeof(FreeModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnlyOneEdgeModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniformModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002D38")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3A")]
	protected ProceduralImageModifier() { }

	[Token(Token = "0x6002D39")]
	public abstract Vector4 CalculateRadius(Rect imageRect) { }

	[Address(RVA = "0x4F6400", Offset = "0x4F5600", Length = "0x8D")]
	[CalledBy(Type = typeof(FreeModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnlyOneEdgeModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniformModifier), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002D38")]
	protected Graphic get__Graphic() { }

}

