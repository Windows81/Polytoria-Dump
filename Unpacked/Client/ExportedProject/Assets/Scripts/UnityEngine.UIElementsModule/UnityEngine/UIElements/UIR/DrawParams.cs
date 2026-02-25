namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200055E")]
internal class DrawParams
{
	[Token(Token = "0x4001222")]
	internal static readonly Rect k_UnlimitedRect; //Field offset: 0x0
	[Token(Token = "0x4001223")]
	internal static readonly Rect k_FullNormalizedRect; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001224")]
	internal readonly Stack<Matrix4x4> view; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001225")]
	internal readonly Stack<Rect> scissor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001226")]
	internal readonly List<Material> defaultMaterial; //Field offset: 0x20

	[Address(RVA = "0x1B7DB10", Offset = "0x1B7CD10", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600268F")]
	private static DrawParams() { }

	[Address(RVA = "0x1B7DB70", Offset = "0x1B7CD70", Length = "0x112")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600268E")]
	public DrawParams() { }

	[Address(RVA = "0x1B7D970", Offset = "0x1B7CB70", Length = "0x192")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600268D")]
	public void Reset() { }

}

