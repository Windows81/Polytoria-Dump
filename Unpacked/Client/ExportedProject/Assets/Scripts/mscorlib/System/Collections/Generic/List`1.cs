namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005E4")]
public class List : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Token(Token = "0x20005E5")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400185F")]
		private List<T> _list; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001860")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001861")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001862")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x170006CE")]
		public override T Current
		{
			[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B5C")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170006CF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE5030", Offset = "0xAE4230", Length = "0x84")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B5D")]
			private get { } //Length: 132
		}

		[Address(RVA = "0xAE56C0", Offset = "0xAE48C0", Length = "0x41")]
		[CalledBy(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(List`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(List`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B58")]
		internal Enumerator(List<T> list) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B59")]
		public override void Dispose() { }

		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5C")]
		public override T get_Current() { }

		[Address(RVA = "0xAE3F00", Offset = "0xAE3100", Length = "0xAF")]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5A")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE38B0", Offset = "0xAE2AB0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5B")]
		private bool MoveNextRare() { }

		[Address(RVA = "0xAE5030", Offset = "0xAE4230", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xAE4E10", Offset = "0xAE4010", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B5E")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x400185E")]
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185A")]
	private T[] _items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185B")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185C")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185D")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170006C6")]
	public int Capacity
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B1E")]
		 get { } //Length: 26
		[Address(RVA = "0xCFDCA0", Offset = "0xCFCEA0", Length = "0x117")]
		[CalledBy(Type = "UnityEngine.SceneManagement.Scene", Member = "GetRootGameObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.List`1<T>&", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Shadow", Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<UIVertex>", "UnityEngine.Color32", typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Outline", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.NoAllocHelpers", Member = "EnsureListElemCount", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.BitmapAllocator32", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BaseShaderInfoStorage"}, ReturnType = "UnityEngine.UIElements.UIR.BMPAlloc")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.ImplicitPool`1", Member = "Get", ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElementListPool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.List`1<VisualElement>")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "set_capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B1F")]
		 set { } //Length: 279
	}

	[Token(Token = "0x170006C7")]
	public override int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B20")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006CC")]
	public override T Item
	{
		[Address(RVA = "0xCFDC40", Offset = "0xCFCE40", Length = "0x5E")]
		[CallerCount(Count = 149)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B25")]
		 get { } //Length: 94
		[Address(RVA = "0xCFDDC0", Offset = "0xCFCFC0", Length = "0x72")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B26")]
		 set { } //Length: 114
	}

	[Token(Token = "0x170006C9")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B22")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006CB")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xCFADC0", Offset = "0xCF9FC0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B24")]
		private get { } //Length: 104
	}

	[Token(Token = "0x170006C8")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B21")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006CA")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B23")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006CD")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0xCFCAC0", Offset = "0xCFBCC0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B28")]
		private get { } //Length: 118
		[Address(RVA = "0xCFCB40", Offset = "0xCFBD40", Length = "0x134")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B29")]
		private set { } //Length: 308
	}

	[Address(RVA = "0xCFCF00", Offset = "0xCFC100", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B57")]
	private static List`1() { }

	[Address(RVA = "0xCFD7E0", Offset = "0xCFC9E0", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddEnumerable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1D")]
	public List`1(IEnumerable<T> collection) { }

	[Address(RVA = "0xCFD0C0", Offset = "0xCFC2C0", Length = "0x89")]
	[CallerCount(Count = 884)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1B")]
	public List`1() { }

	[Address(RVA = "0xCFCFD0", Offset = "0xCFC1D0", Length = "0xE3")]
	[CallerCount(Count = 186)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1C")]
	public List`1(int capacity) { }

	[Address(RVA = "0xCF6020", Offset = "0xCF5220", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2A")]
	public override void Add(T item) { }

	[Address(RVA = "0xCF55D0", Offset = "0xCF47D0", Length = "0x271")]
	[CalledBy(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE490")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B56")]
	private void AddEnumerable(IEnumerable<T> enumerable) { }

	[Address(RVA = "0xCF5DB0", Offset = "0xCF4FB0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2D")]
	public void AddRange(IEnumerable<T> collection) { }

	[Address(RVA = "0xCF5DF0", Offset = "0xCF4FF0", Length = "0xC7")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2B")]
	private void AddWithResize(T item) { }

	[Address(RVA = "0xCF60A0", Offset = "0xCF52A0", Length = "0x73")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2E")]
	public ReadOnlyCollection<T> AsReadOnly() { }

	[Address(RVA = "0xCF6340", Offset = "0xCF5540", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B31")]
	public int BinarySearch(T item, IComparer<T> comparer) { }

	[Address(RVA = "0xCF6290", Offset = "0xCF5490", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B30")]
	public int BinarySearch(T item) { }

	[Address(RVA = "0xCF61E0", Offset = "0xCF53E0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2F")]
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	[Address(RVA = "0xCF6BC0", Offset = "0xCF5DC0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B32")]
	public override void Clear() { }

	[Address(RVA = "0xCF6BF0", Offset = "0xCF5DF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B33")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xCF6E50", Offset = "0xCF6050", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B37")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xCF6E20", Offset = "0xCF6020", Length = "0x2A")]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedTransitionUtils", Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ComputedStyle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedTransitionUtils", Member = "GetOrComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ComputedStyle&"}, ReturnType = "UnityEngine.UIElements.ComputedTransitionProperty[]")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B35")]
	public void CopyTo(T[] array) { }

	[Address(RVA = "0xCF6E80", Offset = "0xCF6080", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B38")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0xCF6EE0", Offset = "0xCF60E0", Length = "0xBF")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer+<>c__DisplayClass54_0", Member = "<UpdateBundleSortList>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "UpdateBundleSortList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<SerializedBundleRef>", "UnityEngine.Rendering.PostProcessing.PostProcessEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B39")]
	public bool Exists(Predicate<T> match) { }

	[Address(RVA = "0xCF7560", Offset = "0xCF6760", Length = "0xCC")]
	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "OnNextClicked", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "FindTabByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.Tab")]
	[CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "AnyTogglesOn", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "UpdateBundleSortList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<SerializedBundleRef>", "UnityEngine.Rendering.PostProcessing.PostProcessEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.HttpHeaderValueCollection`1", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[CalledBy(Type = "System.Net.Http.Headers.MediaTypeHeaderValue", Member = "get_CharSet", ReturnType = typeof(string))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3A")]
	public T Find(Predicate<T> match) { }

	[Address(RVA = "0xCF6FA0", Offset = "0xCF61A0", Length = "0x193")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetQuadrantFromAxesSigns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.AxisSign", "RLD.AxisSign"}, ReturnType = "RLD.PlaneQuadrantId")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetSecondAxisSign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisSign")]
	[CalledBy(Type = "RLD.PlaneDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetFirstAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisDescriptor")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetSecondAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisDescriptor")]
	[CalledBy(Type = "RLD.PlaneIdHelper", Member = "GetFirstAxisSign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PlaneId", "RLD.PlaneQuadrantId"}, ReturnType = "RLD.AxisSign")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3B")]
	public List<T> FindAll(Predicate<T> match) { }

	[Address(RVA = "0xCF72E0", Offset = "0xCF64E0", Length = "0xBB")]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetBaseMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material"}, ReturnType = "UnityEngine.Material")]
	[CalledBy(Type = "UnityEngine.UIElements.DropdownMenu", Member = "AppendSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElementAsset", "System.Collections.Generic.Dictionary`2<Int32, List`1<VisualElementAsset>>", "UnityEngine.UIElements.CreationContext"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "RLD.RTPrefabLibDb", Member = "GetLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "AddKerningPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "AddGlyphPairAdjustmentRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.GlyphValueRecord_Legacy", typeof(uint), "TMPro.GlyphValueRecord_Legacy"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "RemoveKerningPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "AddMaskingMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material", "UnityEngine.Material", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "RemoveStencilMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "ReleaseBaseMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3C")]
	public int FindIndex(Predicate<T> match) { }

	[Address(RVA = "0xCF73A0", Offset = "0xCF65A0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3D")]
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	[Address(RVA = "0xCF7480", Offset = "0xCF6680", Length = "0xD1")]
	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "OnPreviousClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3E")]
	public T FindLast(Predicate<T> match) { }

	[Address(RVA = "0xCF7630", Offset = "0xCF6830", Length = "0xB1")]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMinWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "RunScripts", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "RunLocalScripts", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "GetGlobalFallbacks", ReturnType = "System.IntPtr[]")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B3F")]
	public void ForEach(Action<T> action) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1E")]
	public int get_Capacity() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B20")]
	public override int get_Count() { }

	[Address(RVA = "0xCFDC40", Offset = "0xCFCE40", Length = "0x5E")]
	[CallerCount(Count = 149)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B25")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xCF76F0", Offset = "0xCF68F0", Length = "0x33")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B40")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xCF7730", Offset = "0xCF6930", Length = "0x1A2")]
	[CalledBy(Type = "RLD.RTUndoRedo", Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B43")]
	public List<T> GetRange(int index, int count) { }

	[Address(RVA = "0xCF79E0", Offset = "0xCF6BE0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B44")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xCF92A0", Offset = "0xCF84A0", Length = "0x123")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "FindElementInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "System.Collections.Generic.List`1<Int32>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleVariableContext", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleVariable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Vec3Samples", Member = "AddSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "GetLowestCommonAncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<UInt32>", "System.Collections.Generic.IReadOnlyList`1<Int32>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "<GetLowestCommonAncestorNode>g__CompareTo|125_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "<>c__DisplayClass125_0&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.LatencySimulation", Member = "SimulateSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int), typeof(float), "System.Collections.Generic.List`1<QueuedMessage>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE750")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B46")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xCF8360", Offset = "0xCF7560", Length = "0x4AD")]
	[CalledBy(Type = typeof(List`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE490")]
	[Calls(Type = typeof(List`1), Member = "AddEnumerable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE750")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B48")]
	public void InsertRange(int index, IEnumerable<T> collection) { }

	[Address(RVA = "0xCF93D0", Offset = "0xCF85D0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B27")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0xCF9CB0", Offset = "0xCF8EB0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B49")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xCF9610", Offset = "0xCF8810", Length = "0x1D4")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CalculateHashes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Unsubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4B")]
	public int RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0xCF9890", Offset = "0xCF8A90", Length = "0x93")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4C")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xCF9930", Offset = "0xCF8B30", Length = "0xA3")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexNode", Member = "ReduceConcatenation", ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[CalledBy(Type = "kcp2k.Kcp", Member = "ParseUna", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.Kcp", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "<GetLowestCommonAncestorNode>g__CompareTo|125_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "<>c__DisplayClass125_0&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "GetLowestCommonAncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<UInt32>", "System.Collections.Generic.IReadOnlyList`1<Int32>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.RegexOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Text.RegularExpressions.RegexOptions"}, ReturnType = "System.Text.RegularExpressions.RegexTree")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexNode", Member = "ReduceAlternation", ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[CalledBy(Type = "kcp2k.Kcp", Member = "MoveReceiveBufferReadySegmentsToQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "Canonicalize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal", Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleMatchingContext", Member = "RemoveStyleSheetRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UQuery+UQueryMatcher", Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FixedHeightVirtualizationController`1", Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicHeightVirtualizationController`1", Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicHeightVirtualizationController`1", Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTUndoRedo", Member = "RemoveGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4D")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0xCF9FD0", Offset = "0xCF91D0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4E")]
	public void Reverse() { }

	[Address(RVA = "0xCF9F30", Offset = "0xCF9130", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4F")]
	public void Reverse(int index, int count) { }

	[Address(RVA = "0xCFDCA0", Offset = "0xCFCEA0", Length = "0x117")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "set_capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementListPool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.List`1<VisualElement>")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.ImplicitPool`1", Member = "Get", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.BitmapAllocator32", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BaseShaderInfoStorage"}, ReturnType = "UnityEngine.UIElements.UIR.BMPAlloc")]
	[CalledBy(Type = "RLD.RTScene", Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Outline", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Shadow", Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<UIVertex>", "UnityEngine.Color32", typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.List`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SceneManagement.Scene", Member = "GetRootGameObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.NoAllocHelpers", Member = "EnsureListElemCount", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1F")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xCFDDC0", Offset = "0xCFCFC0", Length = "0x72")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B26")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xCFA560", Offset = "0xCF9760", Length = "0xB7")]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnController", Member = "SortIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseReorderableDragAndDropController", Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Int32>", typeof(bool)}, ReturnType = "UnityEngine.UIElements.StartDragArgs")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CalculateHashes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal", Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "System.Collections.Generic.List`1<SelectorMatchRecord>"}, ReturnType = "UnityEngine.UIElements.ComputedStyle")]
	[CalledBy(Type = "RLD.GizmoQuad3DBorder", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Object2ObjectSnap", Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GameObject", "RLD.Object2ObjectSnap+Config"}, ReturnType = "RLD.Object2ObjectSnap+SnapResult")]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), "System.Nullable`1<Int32>", "Type[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B53")]
	public void Sort(Comparison<T> comparison) { }

	[Address(RVA = "0xCFA430", Offset = "0xCF9630", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B50")]
	public void Sort() { }

	[Address(RVA = "0xCFA7F0", Offset = "0xCF99F0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B51")]
	public void Sort(IComparer<T> comparer) { }

	[Address(RVA = "0xCFA750", Offset = "0xCF9950", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B52")]
	public void Sort(int index, int count, IComparer<T> comparer) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B22")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xCFAB80", Offset = "0xCF9D80", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B41")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xCFABF0", Offset = "0xCF9DF0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B36")]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0xCFADC0", Offset = "0xCF9FC0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B24")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xCFAB80", Offset = "0xCF9D80", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B42")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xCFB010", Offset = "0xCFA210", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B2C")]
	private override int System.Collections.IList.Add(object item) { }

	[Address(RVA = "0xCFB460", Offset = "0xCFA660", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B34")]
	private override bool System.Collections.IList.Contains(object item) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B21")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B23")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0xCFCAC0", Offset = "0xCFBCC0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B28")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0xCFBDF0", Offset = "0xCFAFF0", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B45")]
	private override int System.Collections.IList.IndexOf(object item) { }

	[Address(RVA = "0xCFBF40", Offset = "0xCFB140", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE620")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B47")]
	private override void System.Collections.IList.Insert(int index, object item) { }

	[Address(RVA = "0xCFC340", Offset = "0xCFB540", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B4A")]
	private override void System.Collections.IList.Remove(object item) { }

	[Address(RVA = "0xCFCB40", Offset = "0xCFBD40", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B29")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0xCFCDC0", Offset = "0xCFBFC0", Length = "0xE1")]
	[CallerCount(Count = 102)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B54")]
	public T[] ToArray() { }

	[Address(RVA = "0xCFCEB0", Offset = "0xCFC0B0", Length = "0x4F")]
	[CalledBy(Type = "System.Diagnostics.Switch", Member = "_pruneCachedSwitches", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CE750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B55")]
	public void TrimExcess() { }

}

