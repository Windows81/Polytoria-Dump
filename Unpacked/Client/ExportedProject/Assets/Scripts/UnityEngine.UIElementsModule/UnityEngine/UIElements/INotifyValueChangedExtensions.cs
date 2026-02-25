namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20000E1")]
public static class INotifyValueChangedExtensions
{

	[Address(RVA = "0x6E4A20", Offset = "0x6E3C20", Length = "0xA4")]
	[CalledBy(Type = typeof(BoundsField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "PreAttachElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseCompositeField`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundsIntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RegisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60006D9")]
	public static bool RegisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

	[Address(RVA = "0x6E4B80", Offset = "0x6E3D80", Length = "0xA4")]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "DetachElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateTextFieldVisibility", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "RemoveMultilineComponents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UnregisterRadioButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadioButton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "UnityEngine.UIElements.IGroupBox.OnOptionRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGroupBoxOption)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60006DA")]
	public static bool UnregisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

}

