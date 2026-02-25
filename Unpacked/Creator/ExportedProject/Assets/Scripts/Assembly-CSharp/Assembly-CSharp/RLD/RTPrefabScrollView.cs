namespace RLD;

[Token(Token = "0x20001F5")]
public class RTPrefabScrollView : MonoBehaviour
{
	[Token(Token = "0x20001F6")]
	internal sealed class PrefabPreviewClickedHandler : MulticastDelegate
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
		[Token(Token = "0x6001349")]
		public PrefabPreviewClickedHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600134B")]
		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600134C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600134A")]
		public override void Invoke(RTPrefab prefab) { }

	}

	[Token(Token = "0x20001F7")]
	internal sealed class PrefabPreviewHoverEnterHandler : MulticastDelegate
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
		[Token(Token = "0x600134D")]
		public PrefabPreviewHoverEnterHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600134F")]
		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001350")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600134E")]
		public override void Invoke(RTPrefab prefab) { }

	}

	[Token(Token = "0x20001F8")]
	internal sealed class PrefabPreviewHoverExitHandler : MulticastDelegate
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
		[Token(Token = "0x6001351")]
		public PrefabPreviewHoverExitHandler(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001353")]
		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001354")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001352")]
		public override void Invoke(RTPrefab prefab) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000789")]
	private PrefabPreviewClickedHandler PrefabPreviewClicked; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400078A")]
	private PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400078B")]
	private PrefabPreviewHoverExitHandler PrefabPreviewHoverExit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400078C")]
	private ObjectPool _previewButtonPool; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400078D")]
	private GameObject _gridObject; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400078E")]
	private GridLayoutGroup _gridLayoutGroup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400078F")]
	private List<RTPrefabPreviewButton> _activePreviewButtons; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000790")]
	private List<String> _prefabSearchNames; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000791")]
	private List<String> _prefabSearchMatches; //Field offset: 0x60

	[Token(Token = "0x1400002C")]
	public event PrefabPreviewClickedHandler PrefabPreviewClicked
	{
		[Address(RVA = "0x59BDE0", Offset = "0x59AFE0", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001339")]
		 add { } //Length: 158
		[Address(RVA = "0x59C1B0", Offset = "0x59B3B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600133A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400002D")]
	public event PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter
	{
		[Address(RVA = "0x59BE80", Offset = "0x59B080", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600133B")]
		 add { } //Length: 158
		[Address(RVA = "0x59C250", Offset = "0x59B450", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600133C")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400002E")]
	public event PrefabPreviewHoverExitHandler PrefabPreviewHoverExit
	{
		[Address(RVA = "0x59BF20", Offset = "0x59B120", Length = "0x9E")]
		[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600133D")]
		 add { } //Length: 158
		[Address(RVA = "0x59C2F0", Offset = "0x59B4F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600133E")]
		 remove { } //Length: 158
	}

	[Address(RVA = "0x59BCF0", Offset = "0x59AEF0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001348")]
	public RTPrefabScrollView() { }

	[Address(RVA = "0x59BDE0", Offset = "0x59AFE0", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001339")]
	public void add_PrefabPreviewClicked(PrefabPreviewClickedHandler value) { }

	[Address(RVA = "0x59BE80", Offset = "0x59B080", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600133B")]
	public void add_PrefabPreviewHoverEnter(PrefabPreviewHoverEnterHandler value) { }

	[Address(RVA = "0x59BF20", Offset = "0x59B120", Length = "0x9E")]
	[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600133D")]
	public void add_PrefabPreviewHoverExit(PrefabPreviewHoverExitHandler value) { }

	[Address(RVA = "0x59B130", Offset = "0x59A330", Length = "0x3DA")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabCreatedInLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "SyncWithLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTPrefab), Member = "get_PreviewSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabPreviewButton), Member = "add_HoverExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HoverExitHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabPreviewButton), Member = "remove_HoverExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HoverExitHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabPreviewButton), Member = "add_HoverEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HoverEnterHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabPreviewButton), Member = "remove_HoverEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HoverEnterHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTPrefabPreviewButton), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectPool), Member = "GetPooledObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600133F")]
	public void AddPrefabPreview(RTPrefab prefab) { }

	[Address(RVA = "0x59B510", Offset = "0x59A710", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int), typeof(GrowMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool), Member = "set_GrowAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ObjectPool), Member = "SetPooledObjectsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001343")]
	private void Awake() { }

	[Address(RVA = "0x59B670", Offset = "0x59A870", Length = "0x69")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabLibCleared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool), Member = "MarkAllAsUnused", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001341")]
	public void ClearPreviews() { }

	[Address(RVA = "0x59B6E0", Offset = "0x59A8E0", Length = "0x2D5")]
	[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "OnPrefabSearchFieldValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDbUI), Member = "<Awake>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "prefabNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringMatch), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(string), typeof(Case), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001340")]
	public void FilterPrefabsByName(string name) { }

	[Address(RVA = "0x54AA80", Offset = "0x549C80", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001346")]
	private void OnPrefabPreviewHoverEnter(RTPrefab prefab) { }

	[Address(RVA = "0x54AA60", Offset = "0x549C60", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001347")]
	private void OnPrefabPreviewHoverExit(RTPrefab prefab) { }

	[Address(RVA = "0x59B9C0", Offset = "0x59ABC0", Length = "0x264")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTScene), Member = "GetHoveredUIElements", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.EventSystems.RaycastResult>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.EventSystems.RaycastResult>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001345")]
	private void OnPreviewButtonClicked() { }

	[Address(RVA = "0x59BFC0", Offset = "0x59B1C0", Length = "0x1EC")]
	[CalledBy(Type = typeof(RTPrefabScrollView), Member = "FilterPrefabsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001344")]
	private void prefabNames(List<String> names) { }

	[Address(RVA = "0x59C1B0", Offset = "0x59B3B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600133A")]
	public void remove_PrefabPreviewClicked(PrefabPreviewClickedHandler value) { }

	[Address(RVA = "0x59C250", Offset = "0x59B450", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600133C")]
	public void remove_PrefabPreviewHoverEnter(PrefabPreviewHoverEnterHandler value) { }

	[Address(RVA = "0x59C2F0", Offset = "0x59B4F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600133E")]
	public void remove_PrefabPreviewHoverExit(PrefabPreviewHoverExitHandler value) { }

	[Address(RVA = "0x59BC30", Offset = "0x59AE30", Length = "0xBC")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnActiveLibDropDownChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "OnPrefabRemovedFromLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(RTPrefab)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "<Start>b__48_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool), Member = "MarkAllAsUnused", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabLib), Member = "get_NumPrefabs", ReturnType = typeof(int))]
	[Calls(Type = typeof(RTPrefabLib), Member = "GetPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTPrefab))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "AddPrefabPreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefab)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001342")]
	public void SyncWithLib(RTPrefabLib prefabLib) { }

}

