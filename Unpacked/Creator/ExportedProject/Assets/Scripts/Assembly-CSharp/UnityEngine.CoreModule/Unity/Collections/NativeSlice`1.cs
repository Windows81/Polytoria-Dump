namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeSliceDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsMinMaxWriteRestriction]
[Token(Token = "0x2000046")]
public struct NativeSlice : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice`1<T>>
{
	[ExcludeFromDocs]
	[Token(Token = "0x2000047")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B9")]
		private NativeSlice<T> m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BA")]
		private int m_Index; //Field offset: 0x0

		[Token(Token = "0x1700001B")]
		public override T Current
		{
			[Address(RVA = "0xB08480", Offset = "0xB07680", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C0")]
			 get { } //Length: 68
		}

		[Token(Token = "0x1700001C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB063E0", Offset = "0xB055E0", Length = "0xA0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C1")]
			private get { } //Length: 160
		}

		[Address(RVA = "0xB07770", Offset = "0xB06970", Length = "0xE")]
		[CalledBy(Type = typeof(NativeSlice`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeSlice`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(NativeSlice`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(NativeSlice`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BC")]
		public Enumerator(ref NativeSlice<T>& array) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BD")]
		public override void Dispose() { }

		[Address(RVA = "0xB08480", Offset = "0xB07680", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C0")]
		public override T get_Current() { }

		[Address(RVA = "0xB02140", Offset = "0xB01340", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BE")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB03F80", Offset = "0xB03180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BF")]
		public override void Reset() { }

		[Address(RVA = "0xB063E0", Offset = "0xB055E0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C1")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000B6")]
	internal Byte* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B7")]
	internal int m_Stride; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B8")]
	internal int m_Length; //Field offset: 0x0

	[Token(Token = "0x17000018")]
	public T Item
	{
		[Address(RVA = "0xE24EB0", Offset = "0xE240B0", Length = "0x43")]
		[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 67
		[Address(RVA = "0xE259C0", Offset = "0xE24BC0", Length = "0x51")]
		[CalledBy(Type = "GLTFast.VertexBufferColors", Member = "ScheduleVertexColorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), "Unity.Collections.NativeSlice`1<JobHandle>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "GLTFast.VertexBufferTexCoords`1", Member = "ScheduleVertexUVJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", "System.Int32[]", typeof(int), "Unity.Collections.NativeSlice`1<JobHandle>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		[WriteAccessRequired]
		 set { } //Length: 81
	}

	[Token(Token = "0x1700001A")]
	public int Length
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000019")]
	public int Stride
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xE243E0", Offset = "0xE235E0", Length = "0x17")]
	[CalledBy(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AD")]
	public NativeSlice`1(NativeSlice<T> slice, int start, int length) { }

	[Address(RVA = "0xE24660", Offset = "0xE23860", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	public NativeSlice`1(NativeArray<T> array) { }

	[Address(RVA = "0xE24740", Offset = "0xE23940", Length = "0x5D")]
	[CalledBy(Type = "GLTFast.GltfImportBase", Member = "GetBufferViewSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.IBufferView", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<Byte>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	public NativeSlice`1(NativeArray<T> array, int start, int length) { }

	[Address(RVA = "0xE237B0", Offset = "0xE229B0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpyStride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	[WriteAccessRequired]
	public void CopyFrom(NativeSlice<T> slice) { }

	[Address(RVA = "0xE23E30", Offset = "0xE23030", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B9")]
	public override bool Equals(NativeSlice<T> other) { }

	[Address(RVA = "0xE23E50", Offset = "0xE23050", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE24EB0", Offset = "0xE240B0", Length = "0x43")]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	public T get_Item(int index) { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B5")]
	public int get_Length() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B4")]
	public int get_Stride() { }

	[Address(RVA = "0xE240B0", Offset = "0xE232B0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>&"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B6")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xE24130", Offset = "0xE23330", Length = "0x15")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE25430", Offset = "0xE24630", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AF")]
	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }

	[Address(RVA = "0xE259C0", Offset = "0xE24BC0", Length = "0x51")]
	[CalledBy(Type = "GLTFast.VertexBufferColors", Member = "ScheduleVertexColorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", typeof(int), "Unity.Collections.NativeSlice`1<JobHandle>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "GLTFast.VertexBufferTexCoords`1", Member = "ScheduleVertexUVJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IGltfBuffers", "System.Int32[]", typeof(int), "Unity.Collections.NativeSlice`1<JobHandle>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[Address(RVA = "0xE24150", Offset = "0xE23350", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B7")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xE241F0", Offset = "0xE233F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

