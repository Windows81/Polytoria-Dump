namespace TMPro;

[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200003F")]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <>c__DisplayClass76_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C4")]
		public Toggle nothingToggle; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C5")]
		public Toggle everythingToggle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C6")]
		public TMP_Dropdown <>4__this; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000208")]
		public <>c__DisplayClass76_0() { }

		[Address(RVA = "0x189F8E0", Offset = "0x189EAE0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000209")]
		internal void <Show>b__0(bool x) { }

		[Address(RVA = "0x189F910", Offset = "0x189EB10", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020A")]
		internal void <Show>b__1(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <>c__DisplayClass76_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C7")]
		public DropdownItem item; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C8")]
		public TMP_Dropdown <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600020B")]
		public <>c__DisplayClass76_1() { }

		[Address(RVA = "0x189F940", Offset = "0x189EB40", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020C")]
		internal void <Show>b__2(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private sealed class <DelayedDestroyDropdownList>d__90 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CB")]
		public float delay; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CC")]
		public TMP_Dropdown <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000062")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000210")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000063")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000212")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600020D")]
		public <DelayedDestroyDropdownList>d__90(int <>1__state) { }

		[Address(RVA = "0x189F590", Offset = "0x189E790", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600020F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000210")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000212")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x189F650", Offset = "0x189E850", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000211")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600020E")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000043")]
	internal class DropdownEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x1888AA0", Offset = "0x1887CA0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000207")]
		public DropdownEvent() { }

	}

	[Token(Token = "0x2000040")]
	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40001BC")]
		private TMP_Text m_Text; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x40001BD")]
		private Image m_Image; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x40001BE")]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x40001BF")]
		private Toggle m_Toggle; //Field offset: 0x38

		[Token(Token = "0x1700005B")]
		public Image image
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F1")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F2")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005C")]
		public RectTransform rectTransform
		{
			[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
			[CallerCount(Count = 27)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F3")]
			 get { } //Length: 95
			[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F4")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005A")]
		public TMP_Text text
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001EF")]
			 get { } //Length: 5
			[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F0")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005D")]
		public Toggle toggle
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F5")]
			 get { } //Length: 5
			[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001F6")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
		[CallerCount(Count = 60)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F9")]
		public DropdownItem() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F1")]
		public Image get_image() { }

		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F3")]
		public RectTransform get_rectTransform() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EF")]
		public TMP_Text get_text() { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F5")]
		public Toggle get_toggle() { }

		[Address(RVA = "0x1888AE0", Offset = "0x1887CE0", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001F8")]
		public override void OnCancel(BaseEventData eventData) { }

		[Address(RVA = "0x1888B70", Offset = "0x1887D70", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001F7")]
		public override void OnPointerEnter(PointerEventData eventData) { }

		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F2")]
		public void set_image(Image value) { }

		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F4")]
		public void set_rectTransform(RectTransform value) { }

		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F0")]
		public void set_text(TMP_Text value) { }

		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F6")]
		public void set_toggle(Toggle value) { }

	}

	[Token(Token = "0x2000041")]
	internal class OptionData
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001C0")]
		private string m_Text; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40001C1")]
		private Sprite m_Image; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40001C2")]
		private Color m_Color; //Field offset: 0x20

		[Token(Token = "0x17000060")]
		public Color color
		{
			[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FE")]
			 get { } //Length: 11
			[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FF")]
			 set { } //Length: 8
		}

		[Token(Token = "0x1700005F")]
		public Sprite image
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FC")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FD")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005E")]
		public string text
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FA")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60001FB")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x18899B0", Offset = "0x1888BB0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000200")]
		public OptionData() { }

		[Address(RVA = "0x1889A40", Offset = "0x1888C40", Length = "0x3D")]
		[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000201")]
		public OptionData(string text) { }

		[Address(RVA = "0x1889A80", Offset = "0x1888C80", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000202")]
		public OptionData(Sprite image) { }

		[Address(RVA = "0x18899D0", Offset = "0x1888BD0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000203")]
		public OptionData(string text, Sprite image, Color color) { }

		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FE")]
		public Color get_color() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FC")]
		public Sprite get_image() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FA")]
		public string get_text() { }

		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FF")]
		public void set_color(Color value) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FD")]
		public void set_image(Sprite value) { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FB")]
		public void set_text(string value) { }

	}

	[Token(Token = "0x2000042")]
	internal class OptionDataList
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001C3")]
		private List<OptionData> m_Options; //Field offset: 0x10

		[Token(Token = "0x17000061")]
		public List<OptionData> options
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000204")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000205")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x1889930", Offset = "0x1888B30", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000206")]
		public OptionDataList() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000204")]
		public List<OptionData> get_options() { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000205")]
		public void set_options(List<OptionData> value) { }

	}

	[Token(Token = "0x40001A7")]
	private static readonly OptionData k_NothingOption; //Field offset: 0x0
	[Token(Token = "0x40001A8")]
	private static readonly OptionData k_EverythingOption; //Field offset: 0x8
	[Token(Token = "0x40001A9")]
	private static readonly OptionData k_MixedOption; //Field offset: 0x10
	[Token(Token = "0x40001BB")]
	private static OptionData s_NoOptionData; //Field offset: 0x18
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	private RectTransform m_Template; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	private TMP_Text m_CaptionText; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	private Image m_CaptionImage; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40001AD")]
	private Graphic m_Placeholder; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001AE")]
	private TMP_Text m_ItemText; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40001AF")]
	private Image m_ItemImage; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B0")]
	private int m_Value; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[Token(Token = "0x40001B1")]
	private bool m_MultiSelect; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B2")]
	private OptionDataList m_Options; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B3")]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x40001B4")]
	private float m_AlphaFadeSpeed; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40001B5")]
	private GameObject m_Dropdown; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40001B6")]
	private GameObject m_Blocker; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40001B7")]
	private List<DropdownItem> m_Items; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40001B8")]
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40001B9")]
	private bool validTemplate; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40001BA")]
	private Coroutine m_Coroutine; //Field offset: 0x178

	[Token(Token = "0x17000056")]
	public float alphaFadeSpeed
	{
		[Address(RVA = "0x1890AE0", Offset = "0x188FCE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 9
		[Address(RVA = "0x1890B30", Offset = "0x188FD30", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001C6")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000050")]
	public Image captionImage
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 8
		[Address(RVA = "0x1890B40", Offset = "0x188FD40", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700004F")]
	public TMP_Text captionText
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 8
		[Address(RVA = "0x1890B70", Offset = "0x188FD70", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001B8")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000058")]
	public bool IsExpanded
	{
		[Address(RVA = "0x1890A80", Offset = "0x188FC80", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000053")]
	public Image itemImage
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 8
		[Address(RVA = "0x1890BA0", Offset = "0x188FDA0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001C0")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000052")]
	public TMP_Text itemText
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 8
		[Address(RVA = "0x1890BD0", Offset = "0x188FDD0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001BE")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000059")]
	public bool MultiSelect
	{
		[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 8
		[Address(RVA = "0x1890B20", Offset = "0x188FD20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000055")]
	public DropdownEvent onValueChanged
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 8
		[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000054")]
	public List<OptionData> options
	{
		[Address(RVA = "0x1890AF0", Offset = "0x188FCF0", Length = "0x1E")]
		[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 30
		[Address(RVA = "0x1890C20", Offset = "0x188FE20", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000051")]
	public Graphic placeholder
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 8
		[Address(RVA = "0x1890C60", Offset = "0x188FE60", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001BC")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700004E")]
	public RectTransform template
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 8
		[Address(RVA = "0x1890C90", Offset = "0x188FE90", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Token(Token = "0x60001B6")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000057")]
	public int value
	{
		[Address(RVA = "0x1890B10", Offset = "0x188FD10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 7
		[Address(RVA = "0x1890CC0", Offset = "0x188FEC0", Length = "0xB")]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemEnum", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadMiscControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001C8")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x1890700", Offset = "0x188F900", Length = "0x1D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001EE")]
	private static TMP_Dropdown() { }

	[Address(RVA = "0x18908E0", Offset = "0x188FAE0", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001CE")]
	protected TMP_Dropdown() { }

	[Address(RVA = "0x188C8B0", Offset = "0x188BAB0", Length = "0x356")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E5")]
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	[Address(RVA = "0x188CC10", Offset = "0x188BE10", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D3")]
	public void AddOptions(List<OptionData> options) { }

	[Address(RVA = "0x188CC80", Offset = "0x188BE80", Length = "0x182")]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemEnum", Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D4")]
	public void AddOptions(List<String> options) { }

	[Address(RVA = "0x188CE10", Offset = "0x188C010", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D5")]
	public void AddOptions(List<Sprite> options) { }

	[Address(RVA = "0x188CFA0", Offset = "0x188C1A0", Length = "0x166")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatTween), Member = "AddOnChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenRunner`1), Member = "StartTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001E7")]
	private void AlphaFadeList(float duration, float start, float end) { }

	[Address(RVA = "0x188D110", Offset = "0x188C310", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E6")]
	private void AlphaFadeList(float duration, float alpha) { }

	[Address(RVA = "0x188D1A0", Offset = "0x188C3A0", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CF")]
	protected virtual void Awake() { }

	[Address(RVA = "0x188D2F0", Offset = "0x188C4F0", Length = "0xB9")]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemEnum", Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D6")]
	public void ClearOptions() { }

	[Address(RVA = "0x188D3B0", Offset = "0x188C5B0", Length = "0x541")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_ignoreParentGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "T")]
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
	[Token(Token = "0x60001DF")]
	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	[Address(RVA = "0x188D900", Offset = "0x188CB00", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x60001E1")]
	protected override GameObject CreateDropdownList(GameObject template) { }

	[Address(RVA = "0x188D960", Offset = "0x188CB60", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x60001E3")]
	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[Address(RVA = "0x188D9C0", Offset = "0x188CBC0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__90))]
	[Token(Token = "0x60001EA")]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	[Address(RVA = "0x188DA40", Offset = "0x188CC40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001E0")]
	protected override void DestroyBlocker(GameObject blocker) { }

	[Address(RVA = "0x188DA90", Offset = "0x188CC90", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001E2")]
	protected override void DestroyDropdownList(GameObject dropdownList) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E4")]
	protected override void DestroyItem(DropdownItem item) { }

	[Address(RVA = "0x188DAE0", Offset = "0x188CCE0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DE")]
	private static int EverythingValue(int count) { }

	[Address(RVA = "0x188DB10", Offset = "0x188CD10", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001ED")]
	private static int FirstActiveFlagIndex(int value) { }

	[Address(RVA = "0x1890AE0", Offset = "0x188FCE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C5")]
	public float get_alphaFadeSpeed() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B9")]
	public Image get_captionImage() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B7")]
	public TMP_Text get_captionText() { }

	[Address(RVA = "0x1890A80", Offset = "0x188FC80", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001CB")]
	public bool get_IsExpanded() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BF")]
	public Image get_itemImage() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	public TMP_Text get_itemText() { }

	[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CC")]
	public bool get_MultiSelect() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C3")]
	public DropdownEvent get_onValueChanged() { }

	[Address(RVA = "0x1890AF0", Offset = "0x188FCF0", Length = "0x1E")]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C1")]
	public List<OptionData> get_options() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BB")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B5")]
	public RectTransform get_template() { }

	[Address(RVA = "0x1890B10", Offset = "0x188FD10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C7")]
	public int get_value() { }

	[Address(RVA = "0x768460", Offset = "0x767660", Length = "0x9C")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D8")]
	private static T GetOrAddComponent(GameObject go) { }

	[Address(RVA = "0x188DB30", Offset = "0x188CD30", Length = "0x200")]
	[CalledBy(Type = typeof(DropdownItem), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001E9")]
	public void Hide() { }

	[Address(RVA = "0x188DD40", Offset = "0x188CF40", Length = "0x1F8")]
	[CalledBy(Type = typeof(<DelayedDestroyDropdownList>d__90), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001EB")]
	private void ImmediateDestroyDropdownList() { }

	[Address(RVA = "0x188DF40", Offset = "0x188D140", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DD")]
	private static bool IsEverythingValue(int count, int value) { }

	[Address(RVA = "0x188DF70", Offset = "0x188D170", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[Token(Token = "0x60001DB")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x188DF80", Offset = "0x188D180", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D1")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x188E030", Offset = "0x188D230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D9")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x188E040", Offset = "0x188D240", Length = "0x331")]
	[CalledBy(Type = typeof(<>c__DisplayClass76_0), Member = "<Show>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass76_0), Member = "<Show>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass76_1), Member = "<Show>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001EC")]
	private void OnSelectItem(Toggle toggle) { }

	[Address(RVA = "0x188E030", Offset = "0x188D230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DA")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x188E380", Offset = "0x188D580", Length = "0x45E")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Sprite>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_options", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_itemImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_captionImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_captionText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_template", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_itemText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D2")]
	public void RefreshShownValue() { }

	[Address(RVA = "0x1890B30", Offset = "0x188FD30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C6")]
	public void set_alphaFadeSpeed(float value) { }

	[Address(RVA = "0x1890B40", Offset = "0x188FD40", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001BA")]
	public void set_captionImage(Image value) { }

	[Address(RVA = "0x1890B70", Offset = "0x188FD70", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001B8")]
	public void set_captionText(TMP_Text value) { }

	[Address(RVA = "0x1890BA0", Offset = "0x188FDA0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001C0")]
	public void set_itemImage(Image value) { }

	[Address(RVA = "0x1890BD0", Offset = "0x188FDD0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001BE")]
	public void set_itemText(TMP_Text value) { }

	[Address(RVA = "0x1890B20", Offset = "0x188FD20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001CD")]
	public void set_MultiSelect(bool value) { }

	[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C4")]
	public void set_onValueChanged(DropdownEvent value) { }

	[Address(RVA = "0x1890C20", Offset = "0x188FE20", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C2")]
	public void set_options(List<OptionData> value) { }

	[Address(RVA = "0x1890C60", Offset = "0x188FE60", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001BC")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x1890C90", Offset = "0x188FE90", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Token(Token = "0x60001B6")]
	public void set_template(RectTransform value) { }

	[Address(RVA = "0x1890CC0", Offset = "0x188FEC0", Length = "0xB")]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemEnum", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadMiscControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001C8")]
	public void set_value(int value) { }

	[Address(RVA = "0x188E7E0", Offset = "0x188D9E0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E8")]
	private void SetAlpha(float alpha) { }

	[Address(RVA = "0x188EA20", Offset = "0x188DC20", Length = "0x6ED")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
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
	[Token(Token = "0x60001D7")]
	private void SetupTemplate() { }

	[Address(RVA = "0x188E8A0", Offset = "0x188DAA0", Length = "0x176")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSelectItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Int32>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CA")]
	private void SetValue(int value, bool sendCallback = true) { }

	[Address(RVA = "0x188E890", Offset = "0x188DA90", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60001C9")]
	public void SetValueWithoutNotify(int input) { }

	[Address(RVA = "0x188F110", Offset = "0x188E310", Length = "0x1529")]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Navigation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OptionData), typeof(bool), typeof(DropdownItem), typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+DropdownItem>)}, ReturnType = typeof(DropdownItem))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DC")]
	public void Show() { }

	[Address(RVA = "0x1890640", Offset = "0x188F840", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D0")]
	protected virtual void Start() { }

}

