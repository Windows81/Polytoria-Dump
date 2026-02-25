namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x200024B")]
public class HashSet : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x200024C")]
	public struct ElementCount
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F1")]
		internal int uniqueCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F2")]
		internal int unfoundCount; //Field offset: 0x0

	}

	[Token(Token = "0x200024E")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F6")]
		private HashSet<T> _set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F7")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F8")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F9")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x17000235")]
		public override T Current
		{
			[Address(RVA = "0xB080E0", Offset = "0xB072E0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B2C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000236")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB05DD0", Offset = "0xB04FD0", Length = "0xBE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000B2D")]
			private get { } //Length: 190
		}

		[Address(RVA = "0xB07A00", Offset = "0xB06C00", Length = "0x40")]
		[CalledBy(Type = typeof(HashSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.HashSet`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(HashSet`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(HashSet`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(HashSet`1), Member = "IsSubsetOfHashSetWithSameEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B29")]
		internal Enumerator(HashSet<T> set) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2A")]
		public override void Dispose() { }

		[Address(RVA = "0xB080E0", Offset = "0xB072E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2C")]
		public override T get_Current() { }

		[Address(RVA = "0xB02D30", Offset = "0xB01F30", Length = "0xE7")]
		[CalledBy(Type = typeof(HashSet`1), Member = "IsSubsetOfHashSetWithSameEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.SceneInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SceneDistanceInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpServer", Member = "TickIncoming", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2B")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB05DD0", Offset = "0xB04FD0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB05590", Offset = "0xB04790", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2E")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x200024D")]
	public struct Slot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F3")]
		internal int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F4")]
		internal int next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F5")]
		internal T value; //Field offset: 0x0

	}

	[Token(Token = "0x40003E2")]
	private const int Lower31BitMask = 2147483647; //Field offset: 0x0
	[Token(Token = "0x40003E3")]
	private const int StackAllocThreshold = 100; //Field offset: 0x0
	[Token(Token = "0x40003E4")]
	private const int ShrinkThreshold = 3; //Field offset: 0x0
	[Token(Token = "0x40003E5")]
	private const string CapacityName = "Capacity"; //Field offset: 0x0
	[Token(Token = "0x40003E6")]
	private const string ElementsName = "Elements"; //Field offset: 0x0
	[Token(Token = "0x40003E7")]
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	[Token(Token = "0x40003E8")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E9")]
	private Int32[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EA")]
	private Slot<T>[] _slots; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EB")]
	private int _count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EC")]
	private int _lastIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003ED")]
	private int _freeList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EE")]
	private IEqualityComparer<T> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EF")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F0")]
	private SerializationInfo _siInfo; //Field offset: 0x0

	[Token(Token = "0x17000234")]
	public IEqualityComparer<T> Comparer
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B1C")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000232")]
	public override int Count
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000233")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0B")]
		private get { } //Length: 3
	}

	[Address(RVA = "0xC63010", Offset = "0xC62210", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFD")]
	public HashSet`1() { }

	[Address(RVA = "0xC63EB0", Offset = "0xC630B0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFE")]
	public HashSet`1(IEqualityComparer<T> comparer) { }

	[Address(RVA = "0xC632B0", Offset = "0xC624B0", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFF")]
	public HashSet`1(int capacity) { }

	[Address(RVA = "0xC63E50", Offset = "0xC63050", Length = "0x57")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B00")]
	public HashSet`1(IEnumerable<T> collection) { }

	[Address(RVA = "0xC63530", Offset = "0xC62730", Length = "0x40E")]
	[CalledBy(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = "System.Collections.HashHelpers", Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "UnionWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B01")]
	public HashSet`1(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x358330", Offset = "0x357530", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B02")]
	protected HashSet`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xC63D60", Offset = "0xC62F60", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002CDA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B04")]
	public HashSet`1(int capacity, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0xC5C7E0", Offset = "0xC5B9E0", Length = "0x17")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B11")]
	public override bool Add(T item) { }

	[Address(RVA = "0xC5C370", Offset = "0xC5B570", Length = "0x2BE")]
	[CalledBy(Type = typeof(HashSet`1), Member = "System.Collections.Generic.ICollection<T>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "UnionWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4C50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(HashSet`1), Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180056C20")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B21")]
	private bool AddIfNotPresent(T value) { }

	[Address(RVA = "0xC5C6F0", Offset = "0xC5B8F0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B22")]
	private void AddValue(int index, int hashCode, T value) { }

	[Address(RVA = "0xC5C800", Offset = "0xC5BA00", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B27")]
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }

	[Address(RVA = "0xC5CD30", Offset = "0xC5BF30", Length = "0x411")]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsProperSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B26")]
	private ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }

	[Address(RVA = "0xC5D150", Offset = "0xC5C350", Length = "0x57")]
	[CallerCount(Count = 104)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B06")]
	public override void Clear() { }

	[Address(RVA = "0xC5D7D0", Offset = "0xC5C9D0", Length = "0x18D")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4C50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180056C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B07")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xC5D3E0", Offset = "0xC5C5E0", Length = "0x1B0")]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsProperSupersetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "SetEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B23")]
	private bool ContainsAllElements(IEnumerable<T> other) { }

	[Address(RVA = "0xC5D960", Offset = "0xC5CB60", Length = "0x2CC")]
	[CalledBy(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Collections.HashHelpers", Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B49F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B03")]
	private void CopyFrom(HashSet<T> source) { }

	[Address(RVA = "0xC5E200", Offset = "0xC5D400", Length = "0x223")]
	[CalledBy(Type = typeof(HashSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashSet`1), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1A")]
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	[Address(RVA = "0xC5E1A0", Offset = "0xC5D3A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B08")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xC5DF40", Offset = "0xC5D140", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B19")]
	public void CopyTo(T[] array) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1C")]
	public IEqualityComparer<T> get_Comparer() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0A")]
	public override int get_Count() { }

	[Address(RVA = "0xC5E470", Offset = "0xC5D670", Length = "0x35")]
	[CalledBy(Type = "Mirror.MatchInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneDistanceInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerSceneChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpServer", Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0C")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xC5E4B0", Offset = "0xC5D6B0", Length = "0x218")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(HashSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0F")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xC5EAE0", Offset = "0xC5DCE0", Length = "0x1E8")]
	[CalledBy(Type = typeof(HashSet`1), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.Collections.HashHelpers", Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1F")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0xC5EDA0", Offset = "0xC5DFA0", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Collections.HashHelpers", Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1E")]
	private int Initialize(int capacity) { }

	[Address(RVA = "0xC5EE70", Offset = "0xC5E070", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B28")]
	private int InternalGetHashCode(T item) { }

	[Address(RVA = "0xC5F010", Offset = "0xC5E210", Length = "0x180")]
	[CalledBy(Type = typeof(HashSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.HashSet`1<T>+ElementCount<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4C50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180056C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B25")]
	private int InternalIndexOf(T item) { }

	[Address(RVA = "0xC5F3D0", Offset = "0xC5E5D0", Length = "0x231")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "IsSubsetOfHashSetWithSameEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.HashSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B14")]
	public override bool IsProperSubsetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xC5FA60", Offset = "0xC5EC60", Length = "0x20D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "ContainsAllElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.HashSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B16")]
	public override bool IsProperSupersetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xC60140", Offset = "0xC5F340", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(HashSet`1), Member = "IsSubsetOfHashSetWithSameEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.HashSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B13")]
	public override bool IsSubsetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xC5FC70", Offset = "0xC5EE70", Length = "0x185")]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HashSet`1), Member = "IsProperSubsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B24")]
	private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other) { }

	[Address(RVA = "0xC604D0", Offset = "0xC5F6D0", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "ContainsAllElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B15")]
	public override bool IsSupersetOf(IEnumerable<T> other) { }

	[Address(RVA = "0xC60D90", Offset = "0xC5FF90", Length = "0x65C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(HashSet`1), Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180056C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4C50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B10")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0xC613F0", Offset = "0xC605F0", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B17")]
	public override bool Overlaps(IEnumerable<T> other) { }

	[Address(RVA = "0xC61D90", Offset = "0xC60F90", Length = "0x251")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4C50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180056C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B09")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xC61990", Offset = "0xC60B90", Length = "0x110")]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicHeightVirtualizationController`1", Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1B")]
	public int RemoveWhere(Predicate<T> match) { }

	[Address(RVA = "0xC61FF0", Offset = "0xC611F0", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B20")]
	private void SetCapacity(int newSize) { }

	[Address(RVA = "0xC62270", Offset = "0xC61470", Length = "0x222")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(HashSet`1), Member = "ContainsAllElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(HashSet`1), Member = "CheckUniqueAndUnfoundElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(bool)}, ReturnType = "System.Collections.Generic.HashSet`1<T>+ElementCount<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B18")]
	public override bool SetEquals(IEnumerable<T> other) { }

	[Address(RVA = "0xC5C7E0", Offset = "0xC5B9E0", Length = "0x17")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B05")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0B")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xC62740", Offset = "0xC61940", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0D")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xC62740", Offset = "0xC61940", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xC629B0", Offset = "0xC61BB0", Length = "0x1F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.Collections.HashHelpers", Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1D")]
	public void TrimExcess() { }

	[Address(RVA = "0xC62BB0", Offset = "0xC61DB0", Length = "0x21D")]
	[CalledBy(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(HashSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B12")]
	public override void UnionWith(IEnumerable<T> other) { }

}

