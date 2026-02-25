namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000015")]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <>c__DisplayClass63_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005A")]
		public DropdownItem item; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005B")]
		public Dropdown <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BB")]
		public <>c__DisplayClass63_0() { }

		[Address(RVA = "0x1A91B10", Offset = "0x1A90D10", Length = "0x12D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000BC")]
		internal void <Show>b__0(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400005E")]
		public float delay; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400005F")]
		public Dropdown <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000026")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000027")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BD")]
		public <DelayedDestroyDropdownList>d__75(int <>1__state) { }

		[Address(RVA = "0x1A91830", Offset = "0x1A90A30", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1A918F0", Offset = "0x1A90AF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60000C1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BE")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000019")]
	internal class DropdownEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x1A7EB30", Offset = "0x1A7DD30", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000BA")]
		public DropdownEvent() { }

	}

	[Token(Token = "0x2000016")]
	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x4000053")]
		private Text m_Text; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x4000054")]
		private Image m_Image; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x4000055")]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x4000056")]
		private Toggle m_Toggle; //Field offset: 0x38

		[Token(Token = "0x17000020")]
		public Image image
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A6")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A7")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000021")]
		public RectTransform rectTransform
		{
			[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
			[CallerCount(Count = 27)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A8")]
			 get { } //Length: 95
			[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A9")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700001F")]
		public Text text
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A4")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A5")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000022")]
		public Toggle toggle
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AA")]
			 get { } //Length: 5
			[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AB")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
		[CallerCount(Count = 60)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AE")]
		public DropdownItem() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A6")]
		public Image get_image() { }

		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		public RectTransform get_rectTransform() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		public Text get_text() { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		public Toggle get_toggle() { }

		[Address(RVA = "0x1A7EB70", Offset = "0x1A7DD70", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AD")]
		public override void OnCancel(BaseEventData eventData) { }

		[Address(RVA = "0x1A7EC00", Offset = "0x1A7DE00", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AC")]
		public override void OnPointerEnter(PointerEventData eventData) { }

		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A7")]
		public void set_image(Image value) { }

		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		public void set_rectTransform(RectTransform value) { }

		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		public void set_text(Text value) { }

		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AB")]
		public void set_toggle(Toggle value) { }

	}

	[Token(Token = "0x2000017")]
	internal class OptionData
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000057")]
		private string m_Text; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000058")]
		private Sprite m_Image; //Field offset: 0x18

		[Token(Token = "0x17000024")]
		public Sprite image
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B1")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B2")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000023")]
		public string text
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AF")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B0")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		public OptionData() { }

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		public OptionData(string text) { }

		[Address(RVA = "0x13847D0", Offset = "0x13839D0", Length = "0x31")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		public OptionData(Sprite image) { }

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		public OptionData(string text, Sprite image) { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		public Sprite get_image() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AF")]
		public string get_text() { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		public void set_image(Sprite value) { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B0")]
		public void set_text(string value) { }

	}

	[Token(Token = "0x2000018")]
	internal class OptionDataList
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000059")]
		private List<OptionData> m_Options; //Field offset: 0x10

		[Token(Token = "0x17000025")]
		public List<OptionData> options
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B7")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B8")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x1A91560", Offset = "0x1A90760", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60000B9")]
		public OptionDataList() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		public List<OptionData> get_options() { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		public void set_options(List<OptionData> value) { }

	}

	[Token(Token = "0x4000051")]
	private const int kHighSortingLayer = 30000; //Field offset: 0x0
	[Token(Token = "0x4000052")]
	private static OptionData s_NoOptionData; //Field offset: 0x0
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private RectTransform m_Template; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	private Text m_CaptionText; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private Image m_CaptionImage; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000046")]
	private Text m_ItemText; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000047")]
	private Image m_ItemImage; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000048")]
	private int m_Value; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000049")]
	private OptionDataList m_Options; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Space]
	[Token(Token = "0x400004A")]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private float m_AlphaFadeSpeed; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400004C")]
	private GameObject m_Dropdown; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400004D")]
	private GameObject m_Blocker; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400004E")]
	private List<DropdownItem> m_Items; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400004F")]
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000050")]
	private bool validTemplate; //Field offset: 0x168

	[Token(Token = "0x1700001D")]
	public float alphaFadeSpeed
	{
		[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		 get { } //Length: 9
		[Address(RVA = "0x1A821B0", Offset = "0x1A813B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000081")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000018")]
	public Image captionImage
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000076")]
		 get { } //Length: 8
		[Address(RVA = "0x1A821C0", Offset = "0x1A813C0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x6000077")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000017")]
	public Text captionText
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000074")]
		 get { } //Length: 8
		[Address(RVA = "0x1A821F0", Offset = "0x1A813F0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x6000075")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001A")]
	public Image itemImage
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007A")]
		 get { } //Length: 8
		[Address(RVA = "0x1A82220", Offset = "0x1A81420", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x600007B")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000019")]
	public Text itemText
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000078")]
		 get { } //Length: 8
		[Address(RVA = "0x1A82250", Offset = "0x1A81450", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x6000079")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001C")]
	public DropdownEvent onValueChanged
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007E")]
		 get { } //Length: 8
		[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700001B")]
	public List<OptionData> options
	{
		[Address(RVA = "0x1A82180", Offset = "0x1A81380", Length = "0x1E")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_AllFilesFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_FoldersFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowser+PickMode"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600007C")]
		 get { } //Length: 30
		[Address(RVA = "0x1A82280", Offset = "0x1A81480", Length = "0x36")]
		[CalledBy(Type = "namudev.PropertyGridEnum", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600007D")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000016")]
	public RectTransform template
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000072")]
		 get { } //Length: 8
		[Address(RVA = "0x1A822C0", Offset = "0x1A814C0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x6000073")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001E")]
	public int value
	{
		[Address(RVA = "0x1A821A0", Offset = "0x1A813A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000082")]
		 get { } //Length: 7
		[Address(RVA = "0x1A822F0", Offset = "0x1A814F0", Length = "0xB")]
		[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "SetActiveLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "namudev.PropertyGridEnum", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowser+PickMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000083")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1A81F60", Offset = "0x1A81160", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	private static Dropdown() { }

	[Address(RVA = "0x1A81FE0", Offset = "0x1A811E0", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000086")]
	protected Dropdown() { }

	[Address(RVA = "0x1A7EC80", Offset = "0x1A7DE80", Length = "0x314")]
	[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009B")]
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	[Address(RVA = "0x1A7F120", Offset = "0x1A7E320", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600008D")]
	public void AddOptions(List<Sprite> options) { }

	[Address(RVA = "0x1A7EFA0", Offset = "0x1A7E1A0", Length = "0x173")]
	[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600008C")]
	public void AddOptions(List<String> options) { }

	[Address(RVA = "0x1A7F2A0", Offset = "0x1A7E4A0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600008B")]
	public void AddOptions(List<OptionData> options) { }

	[Address(RVA = "0x1A7F310", Offset = "0x1A7E510", Length = "0x166")]
	[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatTween), Member = "AddOnChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.FloatTween>), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FloatTween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	private void AlphaFadeList(float duration, float start, float end) { }

	[Address(RVA = "0x1A7F480", Offset = "0x1A7E680", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009C")]
	private void AlphaFadeList(float duration, float alpha) { }

	[Address(RVA = "0x1A7F510", Offset = "0x1A7E710", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000087")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1A7F620", Offset = "0x1A7E820", Length = "0x79")]
	[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "ClearLibs", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600008E")]
	public void ClearOptions() { }

	[Address(RVA = "0x1A7F6A0", Offset = "0x1A7E8A0", Length = "0x541")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_ignoreParentGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000095")]
	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	[Address(RVA = "0x1A7FBF0", Offset = "0x1A7EDF0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000097")]
	protected override GameObject CreateDropdownList(GameObject template) { }

	[Address(RVA = "0x1A7FC50", Offset = "0x1A7EE50", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000099")]
	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[Address(RVA = "0x1A7FCB0", Offset = "0x1A7EEB0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__75))]
	[Token(Token = "0x60000A0")]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	[Address(RVA = "0x1A7FD30", Offset = "0x1A7EF30", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000096")]
	protected override void DestroyBlocker(GameObject blocker) { }

	[Address(RVA = "0x1A7FD80", Offset = "0x1A7EF80", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000098")]
	protected override void DestroyDropdownList(GameObject dropdownList) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	protected override void DestroyItem(DropdownItem item) { }

	[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public float get_alphaFadeSpeed() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public Image get_captionImage() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public Text get_captionText() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007A")]
	public Image get_itemImage() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	public Text get_itemText() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public DropdownEvent get_onValueChanged() { }

	[Address(RVA = "0x1A82180", Offset = "0x1A81380", Length = "0x1E")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_AllFilesFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_FoldersFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowser+PickMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007C")]
	public List<OptionData> get_options() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public RectTransform get_template() { }

	[Address(RVA = "0x1A821A0", Offset = "0x1A813A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public int get_value() { }

	[Address(RVA = "0x69DDF0", Offset = "0x69CFF0", Length = "0x14D")]
	[CalledBy(Type = typeof(Dropdown), Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentFastPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000090")]
	private static T GetOrAddComponent(GameObject go) { }

	[Address(RVA = "0x1A7FDD0", Offset = "0x1A7EFD0", Length = "0x1DB")]
	[CalledBy(Type = typeof(DropdownItem), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass63_0), Member = "<Show>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600009F")]
	public void Hide() { }

	[Address(RVA = "0x1A7FFB0", Offset = "0x1A7F1B0", Length = "0x1B6")]
	[CalledBy(Type = typeof(<DelayedDestroyDropdownList>d__75), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A1")]
	private void ImmediateDestroyDropdownList() { }

	[Address(RVA = "0x1A80170", Offset = "0x1A7F370", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[Token(Token = "0x6000093")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x1A80180", Offset = "0x1A7F380", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1A80230", Offset = "0x1A7F430", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1A80240", Offset = "0x1A7F440", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	private void OnSelectItem(Toggle toggle) { }

	[Address(RVA = "0x1A80230", Offset = "0x1A7F430", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1A80360", Offset = "0x1A7F560", Length = "0x204")]
	[CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Sprite>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowser+PickMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_itemImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_itemText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_captionImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_captionText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_template", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_options", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public void RefreshShownValue() { }

	[Address(RVA = "0x1A80630", Offset = "0x1A7F830", Length = "0x129")]
	[CalledBy(Type = typeof(<>c__DisplayClass63_0), Member = "<Show>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Int32>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000085")]
	private void Set(int value, bool sendCallback = true) { }

	[Address(RVA = "0x1A821B0", Offset = "0x1A813B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000081")]
	public void set_alphaFadeSpeed(float value) { }

	[Address(RVA = "0x1A821C0", Offset = "0x1A813C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x6000077")]
	public void set_captionImage(Image value) { }

	[Address(RVA = "0x1A821F0", Offset = "0x1A813F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x6000075")]
	public void set_captionText(Text value) { }

	[Address(RVA = "0x1A82220", Offset = "0x1A81420", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x600007B")]
	public void set_itemImage(Image value) { }

	[Address(RVA = "0x1A82250", Offset = "0x1A81450", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x6000079")]
	public void set_itemText(Text value) { }

	[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007F")]
	public void set_onValueChanged(DropdownEvent value) { }

	[Address(RVA = "0x1A82280", Offset = "0x1A81480", Length = "0x36")]
	[CalledBy(Type = "namudev.PropertyGridEnum", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007D")]
	public void set_options(List<OptionData> value) { }

	[Address(RVA = "0x1A822C0", Offset = "0x1A814C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x6000073")]
	public void set_template(RectTransform value) { }

	[Address(RVA = "0x1A822F0", Offset = "0x1A814F0", Length = "0xB")]
	[CalledBy(Type = "RLD.RTActiveLibDropDown", Member = "SetActiveLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridEnum", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowser+PickMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000083")]
	public void set_value(int value) { }

	[Address(RVA = "0x1A80570", Offset = "0x1A7F770", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009E")]
	private void SetAlpha(float alpha) { }

	[Address(RVA = "0x1A80760", Offset = "0x1A7F960", Length = "0x71C")]
	[CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600008F")]
	private void SetupTemplate(Canvas rootCanvas) { }

	[Address(RVA = "0x1A80620", Offset = "0x1A7F820", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000084")]
	public void SetValueWithoutNotify(int input) { }

	[Address(RVA = "0x1A80E80", Offset = "0x1A80080", Length = "0x1016")]
	[CalledBy(Type = typeof(Dropdown), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dropdown), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dropdown), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OptionData), typeof(bool), typeof(DropdownItem), typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+DropdownItem>)}, ReturnType = typeof(DropdownItem))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000094")]
	public void Show() { }

	[Address(RVA = "0x1A81EA0", Offset = "0x1A810A0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000088")]
	protected virtual void Start() { }

}

