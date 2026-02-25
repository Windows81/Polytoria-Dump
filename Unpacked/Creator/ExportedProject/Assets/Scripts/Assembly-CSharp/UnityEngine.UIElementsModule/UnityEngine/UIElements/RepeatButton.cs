namespace UnityEngine.UIElements;

[Token(Token = "0x2000135")]
public class RepeatButton : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000136")]
	internal class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{

		[Address(RVA = "0x1C2C590", Offset = "0x1C2B790", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600097A")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000137")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40005F1")]
		private UxmlLongAttributeDescription m_Delay; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40005F2")]
		private UxmlLongAttributeDescription m_Interval; //Field offset: 0xD8

		[Address(RVA = "0x1C301E0", Offset = "0x1C2F3E0", Length = "0xEE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlLongAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600097C")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2CB10", Offset = "0x1C2BD10", Length = "0x1AC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RepeatButton), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600097B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005F0")]
	public static readonly string ussClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x40005EE")]
	private Clickable m_Clickable; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40005EF")]
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x3E0

	[Token(Token = "0x17000195")]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x1C1C760", Offset = "0x1C1B960", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Clickable), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000974")]
		internal set { } //Length: 40
	}

	[Address(RVA = "0x1C1C590", Offset = "0x1C1B790", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000979")]
	private static RepeatButton() { }

	[Address(RVA = "0x1C1C6D0", Offset = "0x1C1B8D0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000975")]
	public RepeatButton() { }

	[Address(RVA = "0x1C1C600", Offset = "0x1C1B800", Length = "0xC9")]
	[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RepeatButton), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000976")]
	public RepeatButton(Action clickEvent, long delay, long interval) { }

	[Address(RVA = "0x1C1C4A0", Offset = "0x1C1B6A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "add_clicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000978")]
	internal void AddAction(Action clickEvent) { }

	[Address(RVA = "0x1C1C760", Offset = "0x1C1B960", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000974")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x1C1C4D0", Offset = "0x1C1B6D0", Length = "0xBF")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Clickable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000977")]
	public void SetAction(Action clickEvent, long delay, long interval) { }

}

