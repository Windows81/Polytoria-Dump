namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200012C")]
public class ProgressBar : AbstractProgressBar
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012D")]
	internal class UxmlFactory : UxmlFactory<ProgressBar, UxmlTraits>
	{

		[Address(RVA = "0x1C2C5D0", Offset = "0x1C2B7D0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000943")]
		public UxmlFactory() { }

	}


	[Address(RVA = "0x1C19C80", Offset = "0x1C18E80", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AbstractProgressBar), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000942")]
	public ProgressBar() { }

}

