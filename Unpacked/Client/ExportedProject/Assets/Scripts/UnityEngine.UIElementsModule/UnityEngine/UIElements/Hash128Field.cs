namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000D5")]
public class Hash128Field : TextInputBaseField<Hash128>
{
	[Token(Token = "0x20000D8")]
	private class Hash128Input : TextInputBase<Hash128>
	{

		[Token(Token = "0x170000F4")]
		protected string allowedCharacters
		{
			[Address(RVA = "0x1C04C60", Offset = "0x1C03E60", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60006A8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1C04B00", Offset = "0x1C03D00", Length = "0x158")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006A7")]
		internal Hash128Input() { }

		[Address(RVA = "0x1C049B0", Offset = "0x1C03BB0", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006A9")]
		internal virtual bool AcceptCharacter(char c) { }

		[Address(RVA = "0x1C04C60", Offset = "0x1C03E60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60006A8")]
		protected string get_allowedCharacters() { }

		[Address(RVA = "0x1C04A60", Offset = "0x1C03C60", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006AB")]
		internal static Hash128 Parse(string str) { }

		[Address(RVA = "0x1C04260", Offset = "0x1C03460", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006AA")]
		protected virtual Hash128 StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000D6")]
	internal class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
	{

		[Address(RVA = "0x1C159F0", Offset = "0x1C14BF0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60006A5")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000D7")]
	internal class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
	{

		[Address(RVA = "0x1C16890", Offset = "0x1C15A90", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<UnityEngine.Hash128, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60006A6")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x4000419")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400041A")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400041B")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170000F3")]
	public virtual Hash128 value
	{
		[Address(RVA = "0x1C04890", Offset = "0x1C03A90", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600069C")]
		 get { } //Length: 92
		[Address(RVA = "0x1C048F0", Offset = "0x1C03AF0", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Hash128>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600069D")]
		 set { } //Length: 177
	}

	[Address(RVA = "0x1C04480", Offset = "0x1C03680", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60006A4")]
	private static Hash128Field() { }

	[Address(RVA = "0x1C04880", Offset = "0x1C03A80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600069A")]
	public Hash128Field() { }

	[Address(RVA = "0x1C045A0", Offset = "0x1C037A0", Length = "0x2D2")]
	[CalledBy(Type = typeof(Hash128Field), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600069B")]
	public Hash128Field(string label, int maxLength = -1) { }

	[Address(RVA = "0x1C04890", Offset = "0x1C03A90", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069C")]
	public virtual Hash128 get_value() { }

	[Address(RVA = "0x1C04020", Offset = "0x1C03220", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_isReadOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	[Token(Token = "0x60006A3")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1C048F0", Offset = "0x1C03AF0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Hash128>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069D")]
	public virtual void set_value(Hash128 value) { }

	[Address(RVA = "0x1C041A0", Offset = "0x1C033A0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006A0")]
	public virtual void SetValueWithoutNotify(Hash128 newValue) { }

	[Address(RVA = "0x1C04260", Offset = "0x1C03460", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A2")]
	protected virtual Hash128 StringToValue(string str) { }

	[Address(RVA = "0x1C04300", Offset = "0x1C03500", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600069F")]
	internal virtual void UpdateTextFromValue() { }

	[Address(RVA = "0x1C04390", Offset = "0x1C03590", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600069E")]
	internal virtual void UpdateValueFromText() { }

	[Address(RVA = "0x1C04460", Offset = "0x1C03660", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x60006A1")]
	protected virtual string ValueToString(Hash128 value) { }

}

