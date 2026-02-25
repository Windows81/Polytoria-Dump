namespace UnityEngine.UIElements;

[Token(Token = "0x200009C")]
internal class ButtonStripField : BaseField<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009D")]
	internal class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5400", Offset = "0x1BE4600", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005A8")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009E")]
	internal class UxmlTraits : UxmlTraits<Int32>
	{

		[Address(RVA = "0x1BE9E40", Offset = "0x1BE9040", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005A9")]
		public UxmlTraits() { }

	}

	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000368")]
	private readonly List<Button> m_Buttons; //Field offset: 0x360

	[Address(RVA = "0x1BD8970", Offset = "0x1BD7B70", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005A5")]
	public ButtonStripField() { }

	[Address(RVA = "0x1BD8710", Offset = "0x1BD7910", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A7")]
	private void RefreshButtonsState() { }

	[Address(RVA = "0x1BD8810", Offset = "0x1BD7A10", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A6")]
	public virtual void SetValueWithoutNotify(int newValue) { }

}

