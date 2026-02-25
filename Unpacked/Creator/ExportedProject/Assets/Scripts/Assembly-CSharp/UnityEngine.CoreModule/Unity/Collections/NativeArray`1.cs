namespace Unity.Collections;

[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
[Token(Token = "0x200003D")]
public struct NativeArray : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray`1<T>>
{
	[ExcludeFromDocs]
	[Token(Token = "0x200003E")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AB")]
		private NativeArray<T> m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AC")]
		private int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AD")]
		private T value; //Field offset: 0x0

		[Token(Token = "0x17000012")]
		public override T Current
		{
			[Address(RVA = "0xB082F0", Offset = "0xB074F0", Length = "0x33")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600009A")]
			 get { } //Length: 51
		}

		[Token(Token = "0x17000013")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB05AF0", Offset = "0xB04CF0", Length = "0x96")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x600009B")]
			private get { } //Length: 150
		}

		[Address(RVA = "0xB07440", Offset = "0xB06640", Length = "0x29")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000096")]
		public Enumerator(ref NativeArray<T>& array) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		public override void Dispose() { }

		[Address(RVA = "0xB082F0", Offset = "0xB074F0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		public override T get_Current() { }

		[Address(RVA = "0xB01BE0", Offset = "0xB00DE0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB03F80", Offset = "0xB03180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		public override void Reset() { }

		[Address(RVA = "0xB05AF0", Offset = "0xB04CF0", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView`1))]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x200003F")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[ExcludeFromDocs]
		[Token(Token = "0x2000040")]
		internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000B0")]
			private ReadOnly<T> m_Array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000B1")]
			private int m_Index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000B2")]
			private T value; //Field offset: 0x0

			[Token(Token = "0x17000016")]
			public override T Current
			{
				[Address(RVA = "0xB08440", Offset = "0xB07640", Length = "0x33")]
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[Token(Token = "0x60000A6")]
				 get { } //Length: 51
			}

			[Token(Token = "0x17000017")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xB05AF0", Offset = "0xB04CF0", Length = "0x96")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[DeduplicatedMethod]
				[Token(Token = "0x60000A7")]
				private get { } //Length: 150
			}

			[Address(RVA = "0xB07440", Offset = "0xB06640", Length = "0x29")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A2")]
			public Enumerator(in ReadOnly<T> array) { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A3")]
			public override void Dispose() { }

			[Address(RVA = "0xB08440", Offset = "0xB07640", Length = "0x33")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A6")]
			public override T get_Current() { }

			[Address(RVA = "0xB01BE0", Offset = "0xB00DE0", Length = "0xB4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A4")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB03F80", Offset = "0xB03180", Length = "0x8")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A5")]
			public override void Reset() { }

			[Address(RVA = "0xB05AF0", Offset = "0xB04CF0", Length = "0x96")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A7")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40000AE")]
		internal Void* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AF")]
		internal int m_Length; //Field offset: 0x0

		[Token(Token = "0x17000015")]
		public T Item
		{
			[Address(RVA = "0xE11750", Offset = "0xE10950", Length = "0x93")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600009E")]
			 get { } //Length: 147
		}

		[Token(Token = "0x17000014")]
		public int Length
		{
			[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[Token(Token = "0x600009D")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xCE3150", Offset = "0xCE2350", Length = "0x8")]
		[CallerCount(Count = 311)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009C")]
		internal ReadOnly(Void* buffer, int length) { }

		[Address(RVA = "0xE11750", Offset = "0xE10950", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		public T get_Item(int index) { }

		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		public int get_Length() { }

		[Address(RVA = "0xEC2F90", Offset = "0xEC2190", Length = "0xF0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xEC3920", Offset = "0xEC2B20", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F1FD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xEC3920", Offset = "0xEC2B20", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F1FD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000A8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule"})]
	internal Void* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A9")]
	internal int m_Length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AA")]
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x17000011")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000083")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public T Item
	{
		[Address(RVA = "0xE11750", Offset = "0xE10950", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000081")]
		 get { } //Length: 147
		[Address(RVA = "0xE11A10", Offset = "0xE10C10", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000082")]
		[WriteAccessRequired]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700000F")]
	public int Length
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xE110A0", Offset = "0xE102A0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8DA0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0xE10BE0", Offset = "0xE0FDE0", Length = "0x149")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.UploadHandlerRaw", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8DA0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007D")]
	public NativeArray`1(T[] array, Allocator allocator) { }

	[Address(RVA = "0xE11350", Offset = "0xE10550", Length = "0x10B")]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.RootBase", typeof(int), "System.Nullable`1<NativeArray`1<Single>>&", "System.Nullable`1<JobHandle>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8DA0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public NativeArray`1(NativeArray<T> array, Allocator allocator) { }

	[Address(RVA = "0xE0D5B0", Offset = "0xE0C7B0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
	[DeduplicatedMethod]
	[Token(Token = "0x600007F")]
	private static void Allocate(int length, Allocator allocator, out NativeArray<T>& array) { }

	[Address(RVA = "0xE0D6F0", Offset = "0xE0C8F0", Length = "0x71")]
	[CalledBy(Type = "UnityEngine.Physics", Member = "OnSceneContact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.PhysicsScene", typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rigidbody2D", Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xE0E620", Offset = "0xE0D820", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xE0E530", Offset = "0xE0D730", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public static void Copy(T[] src, NativeArray<T> dst) { }

	[Address(RVA = "0xE0E480", Offset = "0xE0D680", Length = "0xA4")]
	[CalledBy(Type = "UnityEngine.Tilemaps.ITilemap", Member = "RefreshTile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.TileBase", Member = "RefreshTile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int), "UnityEngine.Tilemaps.ITilemap"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	[Address(RVA = "0xE0E880", Offset = "0xE0DA80", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }

	[Address(RVA = "0xE0E240", Offset = "0xE0D440", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[Address(RVA = "0xE0E160", Offset = "0xE0D360", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xE0E010", Offset = "0xE0D210", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000090")]
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xE0F380", Offset = "0xE0E580", Length = "0xD4")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000084")]
	[WriteAccessRequired]
	public override void Dispose() { }

	[Address(RVA = "0xE0F560", Offset = "0xE0E760", Length = "0x1C")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000089")]
	public override bool Equals(NativeArray<T> other) { }

	[Address(RVA = "0xE0F460", Offset = "0xE0E660", Length = "0xF5")]
	[CalledBy(Type = typeof(Nullable`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000083")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xE11750", Offset = "0xE10950", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000081")]
	public T get_Item(int index) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public int get_Length() { }

	[Address(RVA = "0xE0F610", Offset = "0xE0E810", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xE0F8C0", Offset = "0xE0EAC0", Length = "0xC")]
	[CalledBy(Type = typeof(Nullable`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Collections.Generic.GenericEqualityComparer`1", Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x605020", Offset = "0x604220", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000093")]
	private NativeArray<U> InternalReinterpret(int length) { }

	[Address(RVA = "0x605160", Offset = "0x604360", Length = "0x8B")]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddTranslationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Vector3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScaleCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Vector3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	public NativeArray<U> Reinterpret() { }

	[Address(RVA = "0xE11A10", Offset = "0xE10C10", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[Address(RVA = "0xE0FA40", Offset = "0xE0EC40", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xE0FF40", Offset = "0xE0F140", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000088")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xE10500", Offset = "0xE0F700", Length = "0x14A")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<AssignAllAccessorData>d__144", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "InternalGetByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.DownloadHandler"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000085")]
	public T[] ToArray() { }

}

