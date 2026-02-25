namespace UnityEngine.UIElements;

[Token(Token = "0x2000097")]
public class Box : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000098")]
	internal class UxmlFactory : UxmlFactory<Box>
	{

		[Address(RVA = "0x1BE5580", Offset = "0x1BE4780", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000593")]
		public UxmlFactory() { }

	}

	[Token(Token = "0x400035B")]
	public static readonly string ussClassName; //Field offset: 0x0

	[Address(RVA = "0x1BD8610", Offset = "0x1BD7810", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000592")]
	private static Box() { }

	[Address(RVA = "0x1BD8680", Offset = "0x1BD7880", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000591")]
	public Box() { }

}

