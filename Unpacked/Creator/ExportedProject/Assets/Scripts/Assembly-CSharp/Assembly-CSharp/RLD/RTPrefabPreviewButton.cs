namespace RLD;

[Token(Token = "0x20001F2")]
public class RTPrefabPreviewButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x20001F3")]
	internal sealed class HoverEnterHandler : MulticastDelegate
	{

		[Address(RVA = "0x3CD330", Offset = "0x3CC530", Length = "0x124")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001331")]
		public HoverEnterHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001333")]
		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001334")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001332")]
		public override void Invoke(RTPrefab prefab) { }

	}

	[Token(Token = "0x20001F4")]
	internal sealed class HoverExitHandler : MulticastDelegate
	{

		[Address(RVA = "0x3CD330", Offset = "0x3CC530", Length = "0x124")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001335")]
		public HoverExitHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001337")]
		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001338")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001336")]
		public override void Invoke(RTPrefab prefab) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000785")]
	private HoverEnterHandler HoverEnter; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000786")]
	private HoverExitHandler HoverExit; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000787")]
	private Text _text; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000788")]
	private RTPrefab _prefab; //Field offset: 0x38

	[Token(Token = "0x1400002A")]
	public event HoverEnterHandler HoverEnter
	{
		[Address(RVA = "0x585F00", Offset = "0x585100", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001325")]
		 add { } //Length: 158
		[Address(RVA = "0x5860E0", Offset = "0x5852E0", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001326")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400002B")]
	public event HoverExitHandler HoverExit
	{
		[Address(RVA = "0x585FA0", Offset = "0x5851A0", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001327")]
		 add { } //Length: 158
		[Address(RVA = "0x586180", Offset = "0x585380", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001328")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170005F6")]
	public RTPrefab Prefab
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001329")]
		 get { } //Length: 5
		[Address(RVA = "0x586220", Offset = "0x585420", Length = "0x13")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600132A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005F7")]
	public string Text
	{
		[Address(RVA = "0x586040", Offset = "0x585240", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600132B")]
		 get { } //Length: 155
		[Address(RVA = "0x586240", Offset = "0x585440", Length = "0x94")]
		[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600132C")]
		 set { } //Length: 148
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001330")]
	public RTPrefabPreviewButton() { }

	[Address(RVA = "0x585F00", Offset = "0x585100", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001325")]
	public void add_HoverEnter(HoverEnterHandler value) { }

	[Address(RVA = "0x585FA0", Offset = "0x5851A0", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001327")]
	public void add_HoverExit(HoverExitHandler value) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001329")]
	public RTPrefab get_Prefab() { }

	[Address(RVA = "0x586040", Offset = "0x585240", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600132B")]
	public string get_Text() { }

	[Address(RVA = "0x585E40", Offset = "0x585040", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600132F")]
	private void OnEnable() { }

	[Address(RVA = "0x585EA0", Offset = "0x5850A0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600132D")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x585ED0", Offset = "0x5850D0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600132E")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x5860E0", Offset = "0x5852E0", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001326")]
	public void remove_HoverEnter(HoverEnterHandler value) { }

	[Address(RVA = "0x586180", Offset = "0x585380", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001328")]
	public void remove_HoverExit(HoverExitHandler value) { }

	[Address(RVA = "0x586220", Offset = "0x585420", Length = "0x13")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600132A")]
	public void set_Prefab(RTPrefab value) { }

	[Address(RVA = "0x586240", Offset = "0x585440", Length = "0x94")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600132C")]
	public void set_Text(string value) { }

}

