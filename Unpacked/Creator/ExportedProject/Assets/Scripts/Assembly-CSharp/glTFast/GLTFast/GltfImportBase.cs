namespace GLTFast;

[Token(Token = "0x2000020")]
public abstract class GltfImportBase : IGltfReadable, IGltfBuffers, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c__DisplayClass101_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AA")]
		public GltfImportBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AB")]
		public string json; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D0")]
		public <>c__DisplayClass101_0() { }

		[Address(RVA = "0x1071790", Offset = "0x1070990", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000D1")]
		internal RootBase <ParseJsonAndLoadBuffers>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c__DisplayClass110_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AC")]
		public string encodedBytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AD")]
		public GltfImportBase <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D2")]
		public <>c__DisplayClass110_0() { }

		[Address(RVA = "0x10717D0", Offset = "0x10709D0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GltfImportBase), Member = "DecodeEmbedBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ICodeLogger)}, ReturnType = typeof(System.Tuple`2<Byte[], System.String>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000D3")]
		internal Tuple<Byte[], String> <DecodeEmbedBufferAsync>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <>c__DisplayClass124_0
	{
		[Token(Token = "0x2000024")]
		private struct <<InstantiateSceneInternal>g__IterateNodes|0>d : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000B1")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000B3")]
			public <>c__DisplayClass124_0 <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40000B4")]
			public uint nodeIndex; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40000B5")]
			public Action<UInt32, Nullable`1<UInt32>> callback; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x40000B6")]
			public Nullable<UInt32> parentIndex; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x40000B7")]
			private NodeBase <node>5__2; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x40000B8")]
			private TaskAwaiter <>u__1; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x40000B9")]
			private UInt32[] <>7__wrap2; //Field offset: 0x50
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x40000BA")]
			private int <>7__wrap3; //Field offset: 0x58

			[Address(RVA = "0x10712E0", Offset = "0x10704E0", Length = "0x448")]
			[CallerCount(Count = 0)]
			[Calls(Type = "GLTFast.GltfImportBase+<>c__DisplayClass124_0", Member = "<InstantiateSceneInternal>g__IterateNodes|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Nullable`1<System.UInt32>), typeof(System.Action`2<System.UInt32, System.Nullable`1<System.UInt32>>)}, ReturnType = typeof(Task))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 6)]
			[CallsUnknownMethods(Count = 3)]
			[Token(Token = "0x60000D8")]
			private override void MoveNext() { }

			[Address(RVA = "0x1071730", Offset = "0x1070930", Length = "0x5A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			[Token(Token = "0x60000D9")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AE")]
		public GltfImportBase <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AF")]
		public IInstantiator instantiator; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B0")]
		public RootBase gltf; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D4")]
		public <>c__DisplayClass124_0() { }

		[Address(RVA = "0x1071840", Offset = "0x1070A40", Length = "0x243")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(NodeExtension), Member = "GetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeBase), typeof(Vector3&), typeof(Quaternion&), typeof(Vector3&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000D6")]
		internal void <InstantiateSceneInternal>g__CreateHierarchy|1(uint nodeIndex, Nullable<UInt32> parentIndex) { }

		[Address(RVA = "0x1071A90", Offset = "0x1070C90", Length = "0x121")]
		[AsyncStateMachine(typeof(<<InstantiateSceneInternal>g__IterateNodes|0>d))]
		[CalledBy(Type = "GLTFast.GltfImportBase+<>c__DisplayClass124_0+<<InstantiateSceneInternal>g__IterateNodes|0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfImportBase+<InstantiateSceneInternal>d__124", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfImportBase+<>c__DisplayClass124_0+<<InstantiateSceneInternal>g__IterateNodes|0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InstantiateSceneInternal>g__IterateNodes|0>d&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000D5")]
		internal Task <InstantiateSceneInternal>g__IterateNodes|0(uint nodeIndex, Nullable<UInt32> parentIndex, Action<UInt32, Nullable`1<UInt32>> callback) { }

		[Address(RVA = "0x1071BC0", Offset = "0x1070DC0", Length = "0xC13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mesh), Member = "set_bindposes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800242B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180101690")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "GetBindPoses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 13)]
		[Token(Token = "0x60000D7")]
		internal void <InstantiateSceneInternal>g__PopulateHierarchy|2(uint nodeIndex, Nullable<UInt32> parentIndex) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private struct <>c__DisplayClass125_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BB")]
		public int commonAncestor; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000BC")]
		public IReadOnlyList<Int32> parentIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BD")]
		public List<Int32> chain; //Field offset: 0x10

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private struct <AssignAllAccessorData>d__144 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BE")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C0")]
		public RootBase gltf; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000C1")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000C2")]
		private int <s>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x1069020", Offset = "0x1068220", Length = "0x3B9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(NativeArray`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000DA")]
		private override void MoveNext() { }

		[Address(RVA = "0x10693E0", Offset = "0x10685E0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000DB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private struct <CreatePrimitiveContexts>d__143 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C6")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000C7")]
		public RootBase gltf; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000C8")]
		private int <i>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40000C9")]
		private bool <schedule>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000CA")]
		private int <meshIndex>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000CB")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"MeshIndex", "Primitive"})]
		private Enumerator<MeshPrimitiveBase, List<ValueTuple`2<Int32, MeshPrimitiveBase>>> <>7__wrap4; //Field offset: 0x40
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1; //Field offset: 0x68

		[Address(RVA = "0x1069440", Offset = "0x1068640", Length = "0x7B2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<CreatePrimitiveContexts>d__143)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<CreatePrimitiveContexts>d__143&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(GltfImportBase), Member = "PreparePrimitiveIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(MeshPrimitiveBase), typeof(PrimitiveCreateContext&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000DC")]
		private override void MoveNext() { }

		[Address(RVA = "0x1069C00", Offset = "0x1068E00", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000DD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private struct <DecodeEmbedBufferAsync>d__110 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder<Tuple`2<Byte[], String>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000CF")]
		public string encodedBytes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D0")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D1")]
		public bool timeCritical; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000D2")]
		private <>c__DisplayClass110_0 <>8__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000D3")]
		private TaskAwaiter<Tuple`2<Byte[], String>> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x1069C60", Offset = "0x1068E60", Length = "0x5A5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<DecodeEmbedBufferAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<DecodeEmbedBufferAsync>d__110&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<DecodeEmbedBufferAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<DecodeEmbedBufferAsync>d__110&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(GltfImportBase), Member = "DecodeEmbedBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ICodeLogger)}, ReturnType = typeof(System.Tuple`2<Byte[], System.String>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000DE")]
		private override void MoveNext() { }

		[Address(RVA = "0x106A210", Offset = "0x1069410", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000DF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private struct <InstantiateMainSceneAsync>d__66 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D7")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D8")]
		public Transform parent; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D9")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000DA")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x106A280", Offset = "0x1069480", Length = "0x28F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(InstantiationSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateMainSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60000E0")]
		private override void MoveNext() { }

		[Address(RVA = "0x106A520", Offset = "0x1069720", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000E1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private struct <InstantiateMainSceneAsync>d__67 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000DD")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000DE")]
		public IInstantiator instantiator; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000DF")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000E0")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x106A590", Offset = "0x1069790", Length = "0x252")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000E2")]
		private override void MoveNext() { }

		[Address(RVA = "0x106A7F0", Offset = "0x10699F0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000E3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private struct <InstantiateSceneAsync>d__69 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000E3")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000E4")]
		public int sceneIndex; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000E5")]
		public IInstantiator instantiator; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x106A860", Offset = "0x1069A60", Length = "0x376")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfImportBase+<InstantiateSceneInternal>d__124"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateSceneInternal>d__124&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<InstantiateSceneAsync>d__69)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<InstantiateSceneAsync>d__69&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000E4")]
		private override void MoveNext() { }

		[Address(RVA = "0x106ABE0", Offset = "0x1069DE0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000E5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002C")]
	private struct <InstantiateSceneInternal>d__124 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000E9")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000EA")]
		public IInstantiator instantiator; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000EB")]
		public RootBase gltf; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000EC")]
		public int sceneId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000ED")]
		private <>c__DisplayClass124_0 <>8__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000EE")]
		private Scene <scene>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40000EF")]
		private UInt32[] <>7__wrap2; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40000F0")]
		private int <>7__wrap3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1; //Field offset: 0x60

		[Address(RVA = "0x106AC50", Offset = "0x1069E50", Length = "0x973")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<InstantiateSceneInternal>d__124)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<InstantiateSceneInternal>d__124&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "GLTFast.GltfImportBase+<>c__DisplayClass124_0", Member = "<InstantiateSceneInternal>g__IterateNodes|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Nullable`1<System.UInt32>), typeof(System.Action`2<System.UInt32, System.Nullable`1<System.UInt32>>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x60000E6")]
		private override void MoveNext() { }

		[Address(RVA = "0x106B5D0", Offset = "0x106A7D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000E7")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private struct <Load>d__56 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F4")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F5")]
		public string url; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F6")]
		public ImportSettings importSettings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F7")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000F8")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1070290", Offset = "0x106F490", Length = "0x347")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfImportBase+<Load>d__57"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__57&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60000E8")]
		private override void MoveNext() { }

		[Address(RVA = "0x10705E0", Offset = "0x106F7E0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000E9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private struct <Load>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FB")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000FC")]
		public ImportSettings importSettings; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000FD")]
		public Uri url; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000FF")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1070650", Offset = "0x106F850", Length = "0x33F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GltfImportBase+<LoadFromUri>d__98"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadFromUri>d__98&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ImportSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60000EA")]
		private override void MoveNext() { }

		[Address(RVA = "0x10709A0", Offset = "0x106FBA0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000EB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private struct <LoadAccessorData>d__140 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000100")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000102")]
		public RootBase gltf; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000103")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000104")]
		private int <meshCount>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000105")]
		private Dictionary<MeshPrimitiveBase, MorphTargetsContext> <morphTargetsContexts>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000106")]
		private List<JobHandle> <tmpList>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000107")]
		private bool <success>5__5; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000108")]
		private Enumerator<MeshPrimitiveBase, MainBufferType> <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400010A")]
		private int <i>5__7; //Field offset: 0x80

		[Address(RVA = "0x106C360", Offset = "0x106B560", Length = "0x33E4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GltfImportBase), Member = "GetMatricesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Matrix4x4>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "GetVector4Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Quaternion>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Vector3>&), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
		[Calls(Type = typeof(GltfImportBase), Member = "GetIndicesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Int32[]&), typeof(Nullable`1<JobHandle>&), typeof(GCHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3080")]
		[Calls(Type = typeof(GltfImportBase), Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Nullable`1<NativeArray`1<Single>>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AccessorBase), Member = "GetAttributeType", ReturnType = typeof(GltfAccessorAttributeType))]
		[Calls(Type = typeof(AnimationChannelTarget), Member = "GetPath", ReturnType = typeof(Path))]
		[Calls(Type = typeof(RootBase), Member = "get_HasAnimation", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MorphTargetsContext), Member = "GetJobHandle", ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D80")]
		[Calls(Type = typeof(PrimitiveCreateContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PrimitiveCreateContext), Member = "SetPrimitiveIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PrimitiveCreateContextBase), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(KeyValuePair`2), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<LoadAccessorData>d__140)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<LoadAccessorData>d__140&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MaterialBase), Member = "get_RequiresNormals", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F730")]
		[Calls(Type = typeof(GltfImportBase), Member = "CreateMorphTargetsContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshPrimitiveBase), typeof(String[])}, ReturnType = typeof(MorphTargetsContext))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "SetMaterialPointsSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(VertexBufferConfig`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICodeLogger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180101780")]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(MaterialBase), Member = "get_RequiresTangents", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 24)]
		[CallsUnknownMethods(Count = 30)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000EC")]
		private override void MoveNext() { }

		[Address(RVA = "0x106F760", Offset = "0x106E960", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000ED")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private struct <LoadContent>d__99 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010D")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010E")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		[Address(RVA = "0x107C1C0", Offset = "0x107B3C0", Length = "0x2F6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GltfImportBase), Member = "WaitForBufferDownloads", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "WaitForTextureDownloads", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Boolean>), typeof(<LoadContent>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Boolean>&), typeof(<LoadContent>d__99&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60000EE")]
		private override void MoveNext() { }

		[Address(RVA = "0x107C4C0", Offset = "0x107B6C0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000EF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private struct <LoadFromUri>d__98 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400010F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000110")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000111")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000112")]
		public Uri url; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000113")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000114")]
		private TaskAwaiter<IDownload> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000115")]
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40

		[Address(RVA = "0x107C530", Offset = "0x107B730", Length = "0xA48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "DisposeVolatileData", ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "Prepare", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadContent", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadGltfBinaryBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadGltf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000F0")]
		private override void MoveNext() { }

		[Address(RVA = "0x107CF80", Offset = "0x107C180", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000F1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private struct <LoadGltf>d__104 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000116")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000117")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000118")]
		public Uri url; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000119")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400011A")]
		public string json; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400011B")]
		private Uri <baseUri>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400011C")]
		private bool <success>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400011D")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400011E")]
		private TaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x107D810", Offset = "0x107CA10", Length = "0x2E2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UriHelper), Member = "GetBaseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Uri))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GltfImportBase), Member = "ParseJsonAndLoadBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadImages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60000F2")]
		private override void MoveNext() { }

		[Address(RVA = "0x107DB00", Offset = "0x107CD00", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000F3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private struct <LoadGltfBinaryBuffer>d__114 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000120")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000121")]
		public Byte[] bytes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000122")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000123")]
		public Uri uri; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000124")]
		private int <index>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000125")]
		private Uri <baseUri>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000126")]
		private uint <chLength>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000127")]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000128")]
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x107CFF0", Offset = "0x107C1F0", Length = "0x7AE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadImages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GltfImportBase), Member = "ParseJsonAndLoadBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UriHelper), Member = "GetBaseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Uri))]
		[Calls(Type = typeof(GltfGlobals), Member = "IsGltfBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000F4")]
		private override void MoveNext() { }

		[Address(RVA = "0x107D7A0", Offset = "0x107C9A0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000F5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private struct <LoadImageFromBuffer>d__106 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000129")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012B")]
		public Task<Tuple`2<Byte[], String>> decodeBufferTask; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400012C")]
		public GltfImportBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400012D")]
		public int imageIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400012E")]
		public Image img; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012F")]
		private Tuple<Byte[], String> <decodedBuffer>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000130")]
		private TaskAwaiter<Tuple`2<Byte[], String>> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000131")]
		private TaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x107DB70", Offset = "0x107CD70", Length = "0x750")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GltfImportBase), Member = "CreateEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(int), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(GltfImportBase), Member = "GetImageFormatFromMimeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ImageFormat))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000F6")]
		private override void MoveNext() { }

		[Address(RVA = "0x107E2D0", Offset = "0x107D4D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000F7")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private struct <LoadImages>d__105 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000132")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000134")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000135")]
		public Uri baseUri; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000136")]
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x107E330", Offset = "0x107D530", Length = "0x1018")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GltfImportBase), Member = "GetImageFormatFromMimeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ImageFormat))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(UriHelper), Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Uri), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<LoadImages>d__105)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<LoadImages>d__105&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(UriHelper), Member = "GetImageFormatFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ImageFormat))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadImageFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Tuple`2<Byte[], System.String>>), typeof(int), typeof(Image)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(GltfImportBase), Member = "DecodeEmbedBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Tuple`2<Byte[], System.String>>))]
		[Calls(Type = typeof(GltfImportBase), Member = "<LoadImages>g__SetImageGamma|105_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureInfoBase)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(TextureBase), Member = "GetImageIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 32)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000F8")]
		private override void MoveNext() { }

		[Address(RVA = "0x107F350", Offset = "0x107E550", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000F9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000036")]
	private struct <ParseJsonAndLoadBuffers>d__101 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000137")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000139")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400013A")]
		public string json; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400013B")]
		public Uri baseUri; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400013C")]
		private TaskAwaiter<RootBase> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400013D")]
		private int <bufferCount>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400013E")]
		private int <i>5__3; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400013F")]
		private TaskAwaiter<Tuple`2<Byte[], String>> <>u__2; //Field offset: 0x48

		[Address(RVA = "0x107F3B0", Offset = "0x107E5B0", Length = "0x976")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<ParseJsonAndLoadBuffers>d__101)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<ParseJsonAndLoadBuffers>d__101&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(GltfImportBase), Member = "DecodeEmbedBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Tuple`2<Byte[], System.String>>))]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Uri)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UriHelper), Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(GltfImportBase), Member = "CheckExtensionSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		[Token(Token = "0x60000FA")]
		private override void MoveNext() { }

		[Address(RVA = "0x107FD30", Offset = "0x107EF30", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000FB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private struct <Prepare>d__118 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000140")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000142")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000143")]
		private bool <success>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000144")]
		private TaskAwaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000145")]
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000146")]
		private YieldAwaiter <>u__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x4000147")]
		private bool <imageCreateContextsLeft>5__3; //Field offset: 0x41
		[FieldOffset(Offset = "0x42")]
		[Token(Token = "0x4000148")]
		private bool <loadedAny>5__4; //Field offset: 0x42
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000149")]
		private int <i>5__5; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400014A")]
		private PrimitiveCreateContextBase <primitiveContext>5__6; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400014B")]
		private TaskAwaiter<Nullable`1<MeshResult>> <>u__4; //Field offset: 0x50

		[Address(RVA = "0x107FDA0", Offset = "0x107EFA0", Length = "0x400")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000FC")]
		private override void MoveNext() { }

		[Address(RVA = "0x10835E0", Offset = "0x10827E0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000FD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private struct <WaitForBufferDownloads>d__107 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400014E")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400014F")]
		private Enumerator<Int32, Task<IDownload>> <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000150")]
		private KeyValuePair<Int32, Task`1<IDownload>> <downloadPair>5__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000151")]
		private TaskAwaiter<IDownload> <>u__1; //Field offset: 0x60

		[Address(RVA = "0x1083650", Offset = "0x1082850", Length = "0x699")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<WaitForBufferDownloads>d__107)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<WaitForBufferDownloads>d__107&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Token(Token = "0x60000FE")]
		private override void MoveNext() { }

		[Address(RVA = "0x1083CF0", Offset = "0x1082EF0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x60000FF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private struct <WaitForTextureDownloads>d__108 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000152")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000154")]
		public GltfImportBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000155")]
		private Enumerator<Int32, TextureDownloadBase> <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000156")]
		private KeyValuePair<Int32, TextureDownloadBase> <dl>5__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1; //Field offset: 0x60

		[Address(RVA = "0x1083D60", Offset = "0x1082F60", Length = "0xAC2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<WaitForTextureDownloads>d__108)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<WaitForTextureDownloads>d__108&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GltfImportBase), Member = "CreateEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(int), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GltfImportBase), Member = "GetImageName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(GltfImportBase), Member = "LoadImageFromBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000100")]
		private override void MoveNext() { }

		[Address(RVA = "0x1084830", Offset = "0x1083A30", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x6000101")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400007E")]
	internal const int DefaultBatchCount = 512; //Field offset: 0x0
	[Token(Token = "0x400007F")]
	private const int k_JsonParseSpeed = 80000000; //Field offset: 0x0
	[Token(Token = "0x4000080")]
	private const int k_Base64DecodeSpeed = 150000000; //Field offset: 0x0
	[Token(Token = "0x4000081")]
	private const string k_PrimitiveName = "Primitive"; //Field offset: 0x0
	[Token(Token = "0x4000082")]
	private static readonly HashSet<String> k_SupportedExtensions; //Field offset: 0x0
	[Token(Token = "0x4000083")]
	private static IDeferAgent s_DefaultDeferAgent; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000084")]
	private IDownloadProvider m_DownloadProvider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000085")]
	private IMaterialGenerator m_MaterialGenerator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000086")]
	private IDeferAgent m_DeferAgent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000087")]
	private Dictionary<Type, ImportAddonInstance> m_ImportInstances; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000088")]
	private ImportSettings m_Settings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000089")]
	private Byte[][] m_Buffers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400008A")]
	private Nullable<GCHandle>[] m_BufferHandles; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400008B")]
	private NativeArray<Byte>[] m_NativeBuffers; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008C")]
	private GlbBinChunk[] m_BinChunks; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400008D")]
	private Dictionary<Int32, Task`1<IDownload>> m_DownloadTasks; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400008E")]
	private Dictionary<Int32, TextureDownloadBase> m_TextureDownloadTasks; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400008F")]
	private AccessorDataBase[] m_AccessorData; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000090")]
	private AccessorUsage[] m_AccessorUsage; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000091")]
	private JobHandle m_AccessorJobsHandle; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000092")]
	private PrimitiveCreateContextBase[] m_PrimitiveContexts; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000093")]
	private Dictionary<MeshPrimitiveBase, VertexBufferConfigBase> m_VertexAttributes; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000094")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"MeshIndex", "Primitive"})]
	private Dictionary<MeshPrimitiveBase, List`1<ValueTuple`2<Int32, MeshPrimitiveBase>>>[] m_MeshPrimitiveCluster; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000095")]
	private List<ImageCreateContext> m_ImageCreateContexts; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000096")]
	private Texture2D[] m_Images; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000097")]
	private Texture2D[] m_Textures; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000098")]
	private ImageFormat[] m_ImageFormats; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000099")]
	private Boolean[] m_ImageReadable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400009A")]
	private Boolean[] m_ImageGamma; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400009B")]
	private Nullable<GlbBinChunk> m_GlbBinChunk; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400009C")]
	private HashSet<Int32> m_MaterialPointsSupport; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400009D")]
	private bool m_DefaultMaterialPointsSupport; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400009E")]
	private Material[] m_Materials; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400009F")]
	private List<Object> m_Resources; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000A0")]
	private String[] m_NodeNames; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000A1")]
	private MeshResult[] m_Primitives; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000A2")]
	private Int32[] m_MeshPrimitiveIndex; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40000A3")]
	private Matrix4x4[][] m_SkinsInverseBindMatrices; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40000A4")]
	private AnimationClip[] m_AnimationClips; //Field offset: 0x120
	[CompilerGenerated]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40000A5")]
	private bool <LoadingDone>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[FieldOffset(Offset = "0x129")]
	[Token(Token = "0x40000A6")]
	private bool <LoadingError>k__BackingField; //Field offset: 0x129
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40000A7")]
	private ICodeLogger m_Logger; //Field offset: 0x130
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40000A8")]
	private Action LoadAccessorDataEvent; //Field offset: 0x138
	[CompilerGenerated]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000A9")]
	private Action<Int32, Int32, Int32[]> MeshResultAssigned; //Field offset: 0x140

	[Token(Token = "0x17000019")]
	public Nullable<Int32> DefaultSceneIndex
	{
		[Address(RVA = "0x1068C00", Offset = "0x1067E00", Length = "0xB7")]
		[CalledBy(Type = typeof(GltfAsset), Member = "PostInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GltfAssetBase), Member = "PostInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600008E")]
		 get { } //Length: 183
	}

	[Token(Token = "0x17000017")]
	public private bool LoadingDone
	{
		[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000081")]
		 get { } //Length: 8
		[Address(RVA = "0x1068D90", Offset = "0x1067F90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000082")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000018")]
	public private bool LoadingError
	{
		[Address(RVA = "0x1068CC0", Offset = "0x1067EC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000083")]
		 get { } //Length: 8
		[Address(RVA = "0x1068DA0", Offset = "0x1067FA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000084")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	protected abstract RootBase Root
	{
		[Token(Token = "0x600007F")]
		 get { } //Length: 0
		[Token(Token = "0x6000080")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700001A")]
	public int SceneCount
	{
		[Address(RVA = "0x1068CD0", Offset = "0x1067ED0", Length = "0xBA")]
		[CalledBy(Type = typeof(GltfAssetBase), Member = "get_SceneCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GltfAssetBase), Member = "get_SceneNames", ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600008F")]
		 get { } //Length: 186
	}

	[Address(RVA = "0x1068780", Offset = "0x1067980", Length = "0x1B2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60000CC")]
	private static GltfImportBase() { }

	[Address(RVA = "0x1068940", Offset = "0x1067B40", Length = "0x2BC")]
	[CalledBy(Type = typeof(GltfImportBase`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18105A2C0")]
	[Calls(Type = typeof(MaterialGenerator), Member = "GetDefaultMaterialGenerator", ReturnType = typeof(IMaterialGenerator))]
	[Calls(Type = typeof(ImportAddonRegistry), Member = "InjectAllAddons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GltfImportBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000085")]
	public GltfImportBase(IDownloadProvider downloadProvider = null, IDeferAgent deferAgent = null, IMaterialGenerator materialGenerator = null, ICodeLogger logger = null) { }

	[Address(RVA = "0x1067F80", Offset = "0x1067180", Length = "0x1F8")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60000CD")]
	internal static void <Dispose>g__DisposeArray|70_0(IEnumerable<Object> objects) { }

	[Address(RVA = "0x1068180", Offset = "0x1067380", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60000CF")]
	internal static bool <GetLowestCommonAncestorNode>g__CompareTo|125_0(int nodeId, ref <>c__DisplayClass125_0 unnamed_param_1) { }

	[Address(RVA = "0x1068360", Offset = "0x1067560", Length = "0x135")]
	[CalledBy(Type = typeof(<LoadImages>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(TextureBase), Member = "GetImageIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	private void <LoadImages>g__SetImageGamma|105_0(TextureInfoBase txtInfo) { }

	[Address(RVA = "0x1060720", Offset = "0x105F920", Length = "0xF1")]
	[AsyncStateMachine(typeof(<AssignAllAccessorData>d__144))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AssignAllAccessorData>d__144)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AssignAllAccessorData>d__144&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	private Task AssignAllAccessorData(RootBase gltf) { }

	[Address(RVA = "0x1060820", Offset = "0x105FA20", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32FlippedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32FlippedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C2")]
	private static void CalculateIndicesJob(MeshPrimitiveBase primitive, int vertexCount, MeshTopology topology, out Int32[] indices, out JobHandle jobHandle, out GCHandle resultHandle) { }

	[Address(RVA = "0x1060A30", Offset = "0x105FC30", Length = "0x71E")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CheckExtensionSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801015F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009E")]
	private bool CheckExtensionSupport(IEnumerable<String> extensions, bool required = true) { }

	[Address(RVA = "0x10609D0", Offset = "0x105FBD0", Length = "0x59")]
	[CalledBy(Type = typeof(<ParseJsonAndLoadBuffers>d__101), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GltfImportBase), Member = "CheckExtensionSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009D")]
	private bool CheckExtensionSupport(RootBase gltfRoot) { }

	[Address(RVA = "0x1061150", Offset = "0x1060350", Length = "0x165")]
	[CalledBy(Type = typeof(<LoadImageFromBuffer>d__106), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WaitForTextureDownloads>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CreateTexturesFromBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<GLTFast.Schema.Image>), typeof(System.Collections.Generic.IReadOnlyList`1<GLTFast.Schema.BufferViewBase>), typeof(System.Collections.Generic.ICollection`1<GLTFast.ImageCreateContext>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B9")]
	private Texture2D CreateEmptyTexture(Image img, int index, bool forceSampleLinear) { }

	[Address(RVA = "0x10612C0", Offset = "0x10604C0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000B8")]
	private static MemCopyJob CreateMemCopyJob(BufferViewBase bufferView, Byte[] buffer, GlbBinChunk chunk, ImageCreateContext icc) { }

	[Address(RVA = "0x1061340", Offset = "0x1060540", Length = "0x175")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MorphTargetsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[]), typeof(IDeferAgent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MorphTargetsContext), Member = "AddMorphTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGltfBuffers), typeof(int), typeof(int), typeof(int), typeof(ICodeLogger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000BD")]
	private MorphTargetsContext CreateMorphTargetsContext(MeshPrimitiveBase primitive, String[] meshTargetNames) { }

	[Address(RVA = "0x10614C0", Offset = "0x10606C0", Length = "0x106")]
	[AsyncStateMachine(typeof(<CreatePrimitiveContexts>d__143))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreatePrimitiveContexts>d__143)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreatePrimitiveContexts>d__143&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	private Task CreatePrimitiveContexts(RootBase gltf) { }

	[Address(RVA = "0x10615D0", Offset = "0x10607D0", Length = "0x5C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriHelper), Member = "GetImageFormatFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ImageFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180101540")]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GltfImportBase), Member = "CreateEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(int), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(GltfImportBase), Member = "GetImageFormatFromMimeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ImageFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B7")]
	private void CreateTexturesFromBuffers(IReadOnlyList<Image> srcImages, IReadOnlyList<BufferViewBase> bufferViews, ICollection<ImageCreateContext> contexts) { }

	[Address(RVA = "0x1061BA0", Offset = "0x1060DA0", Length = "0x826")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GltfImportBase), Member = "GetUniqueNodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(uint), typeof(System.Collections.Generic.ICollection`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 24)]
	[Token(Token = "0x60000B0")]
	private Int32[] CreateUniqueNames() { }

	[Address(RVA = "0x1062510", Offset = "0x1061710", Length = "0x1C5")]
	[CalledBy(Type = typeof(<>c__DisplayClass110_0), Member = "<DecodeEmbedBufferAsync>b__0", ReturnType = typeof(System.Tuple`2<Byte[], System.String>))]
	[CalledBy(Type = typeof(<DecodeEmbedBufferAsync>d__110), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A6")]
	private static Tuple<Byte[], String> DecodeEmbedBuffer(string encodedBytes, ICodeLogger logger) { }

	[Address(RVA = "0x10623D0", Offset = "0x10615D0", Length = "0x135")]
	[AsyncStateMachine(typeof(<DecodeEmbedBufferAsync>d__110))]
	[CalledBy(Type = typeof(<LoadImages>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseJsonAndLoadBuffers>d__101), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DecodeEmbedBufferAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DecodeEmbedBufferAsync>d__110&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A5")]
	private Task<Tuple`2<Byte[], String>> DecodeEmbedBufferAsync(string encodedBytes, bool timeCritical = false) { }

	[Address(RVA = "0x1062A20", Offset = "0x1061C20", Length = "0x2BB")]
	[CalledBy(Type = typeof(GltfAssetBase), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfAssetBase), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GltfImportBase), Member = "<Dispose>g__DisposeArray|70_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600008D")]
	public override void Dispose() { }

	[Address(RVA = "0x10626E0", Offset = "0x10618E0", Length = "0x333")]
	[CalledBy(Type = typeof(<LoadFromUri>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B2")]
	private void DisposeVolatileData() { }

	[Address(RVA = "0x1068C00", Offset = "0x1067E00", Length = "0xB7")]
	[CalledBy(Type = typeof(GltfAsset), Member = "PostInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfAssetBase), Member = "PostInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInstantiator), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600008E")]
	public Nullable<Int32> get_DefaultSceneIndex() { }

	[Address(RVA = "0x420950", Offset = "0x41FB50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000081")]
	public bool get_LoadingDone() { }

	[Address(RVA = "0x1068CC0", Offset = "0x1067EC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000083")]
	public bool get_LoadingError() { }

	[Token(Token = "0x600007F")]
	protected abstract RootBase get_Root() { }

	[Address(RVA = "0x1068CD0", Offset = "0x1067ED0", Length = "0xBA")]
	[CalledBy(Type = typeof(GltfAssetBase), Member = "get_SceneCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GltfAssetBase), Member = "get_SceneNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600008F")]
	public int get_SceneCount() { }

	[Address(RVA = "0x1062F00", Offset = "0x1062100", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C9")]
	public override void GetAccessorSparseIndices(AccessorSparseIndices sparseIndices, out Void* data) { }

	[Address(RVA = "0x1063000", Offset = "0x1062200", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000CA")]
	public override void GetAccessorSparseValues(AccessorSparseValues sparseValues, out Void* data) { }

	[Address(RVA = "0x1063100", Offset = "0x1062300", Length = "0x1CF")]
	[CalledBy(Type = typeof(<>c__DisplayClass124_0), Member = "<InstantiateSceneInternal>g__PopulateHierarchy|2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Nullable`1<System.UInt32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000098")]
	public override Matrix4x4[] GetBindPoses(int skinId) { }

	[Address(RVA = "0x519B30", Offset = "0x518D30", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	private Byte[] GetBuffer(int index) { }

	[Address(RVA = "0x1063560", Offset = "0x1062760", Length = "0xCE")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetIndicesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Int32[]&), typeof(Nullable`1<JobHandle>&), typeof(GCHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetMatricesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Matrix4x4>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector3Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Vector3>&), typeof(Nullable`1<JobHandle>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetVector4Job", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(NativeArray`1<Quaternion>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Nullable`1<NativeArray`1<Single>>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferViewSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBufferView), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000AB")]
	private NativeSlice<Byte> GetBufferView(int bufferViewIndex, int offset = 0, int length = 0) { }

	[Address(RVA = "0x10632D0", Offset = "0x10624D0", Length = "0x284")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeSlice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000AC")]
	private NativeSlice<Byte> GetBufferViewSlice(IBufferView bufferView, int offset = 0, int length = 0) { }

	[Address(RVA = "0x1063630", Offset = "0x1062830", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	public override Material GetDefaultMaterial() { }

	[Address(RVA = "0x1063750", Offset = "0x1062950", Length = "0x11A")]
	[CalledBy(Type = typeof(<LoadImageFromBuffer>d__106), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadImages>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CreateTexturesFromBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<GLTFast.Schema.Image>), typeof(System.Collections.Generic.IReadOnlyList`1<GLTFast.Schema.BufferViewBase>), typeof(System.Collections.Generic.ICollection`1<GLTFast.ImageCreateContext>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CB")]
	private static ImageFormat GetImageFormatFromMimeType(string mimeType) { }

	[Address(RVA = "0x1063870", Offset = "0x1062A70", Length = "0x85")]
	[CalledBy(Type = typeof(<WaitForTextureDownloads>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BA")]
	private static string GetImageName(Image img, int index) { }

	[Address(RVA = "0x1063900", Offset = "0x1062B00", Length = "0x6A2")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt8ToInt32FlippedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt8ToInt32FlippedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt8ToInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt8ToInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt16ToInt32FlippedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt16ToInt32FlippedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt16ToInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt16ToInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt32ToInt32FlippedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt32ToInt32FlippedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt32ToInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertIndicesUInt32ToInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C3")]
	private void GetIndicesJob(RootBase gltf, int accessorIndex, out Int32[] indices, out Nullable<JobHandle>& jobHandle, out GCHandle resultHandle, bool flip) { }

	[Address(RVA = "0x1063FB0", Offset = "0x10631B0", Length = "0x3EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B4")]
	private static int GetLowestCommonAncestorNode(IEnumerable<UInt32> nodes, IReadOnlyList<Int32> parentIndex) { }

	[Address(RVA = "0x1064410", Offset = "0x1063610", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000091")]
	public override Material GetMaterial(int index = 0) { }

	[Address(RVA = "0x10643A0", Offset = "0x10635A0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000AF")]
	private bool GetMaterialPointsSupport(int materialIndex) { }

	[Address(RVA = "0x1064450", Offset = "0x1063650", Length = "0x36A")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertMatricesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertMatricesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	private void GetMatricesJob(RootBase gltf, int accessorIndex, out NativeArray<Matrix4x4>& matrices, out Nullable<JobHandle>& jobHandle) { }

	[Address(RVA = "0x10647C0", Offset = "0x10639C0", Length = "0x36F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x60000B5")]
	private Int32[] GetParentIndices() { }

	[Address(RVA = "0x1064B30", Offset = "0x1063D30", Length = "0x6CC")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GltfImportBase), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.Byte>), typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarInt8ToFloatNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarInt8ToFloatNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarUInt8ToFloatNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarUInt8ToFloatNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarInt16ToFloatNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarInt16ToFloatNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarUInt16ToFloatNormalizedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertScalarUInt16ToFloatNormalizedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C7")]
	private void GetScalarJob(RootBase gltf, int accessorIndex, out Nullable<NativeArray`1<Single>>& scalars, out Nullable<JobHandle>& jobHandle) { }

	[Address(RVA = "0x1065200", Offset = "0x1064400", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000090")]
	public string GetSceneName(int sceneIndex) { }

	[Address(RVA = "0x10652A0", Offset = "0x10644A0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000095")]
	public override CameraBase GetSourceCamera(uint index) { }

	[Address(RVA = "0x1065440", Offset = "0x1064640", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000096")]
	public override LightPunctual GetSourceLightPunctual(uint index) { }

	[Address(RVA = "0x1065580", Offset = "0x1064780", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000097")]
	public override TextureBase GetSourceTexture(int index = 0) { }

	[Address(RVA = "0x10656C0", Offset = "0x10648C0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000093")]
	public override Texture2D GetTexture(int index = 0) { }

	[Address(RVA = "0x1065700", Offset = "0x1064900", Length = "0x2B7")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "CreateUniqueNames", ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60000B1")]
	private static string GetUniqueNodeName(RootBase gltf, uint index, ICollection<String> excludeNames) { }

	[Address(RVA = "0x10659C0", Offset = "0x1064BC0", Length = "0x407")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3FloatToFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertVector3FloatToFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	private void GetVector3Job(RootBase gltf, int accessorIndex, out NativeArray<Vector3>& vectors, out Nullable<JobHandle>& jobHandle, bool flip) { }

	[Address(RVA = "0x1065DD0", Offset = "0x1064FD0", Length = "0x489")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsFloatToFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsFloatToFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsInt16ToFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsInt16ToFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsInt8ToFloatJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertRotationsInt8ToFloatJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AccessorBase), Member = "get_IsSparse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GltfImportBase), Member = "GetBufferView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C6")]
	private void GetVector4Job(RootBase gltf, int accessorIndex, out NativeArray<Quaternion>& vectors, out Nullable<JobHandle>& jobHandle) { }

	[Address(RVA = "0x1062CE0", Offset = "0x1061EE0", Length = "0x21D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60000C8")]
	private override void GLTFast.IGltfBuffers.GetAccessor(int index, out AccessorBase accessor, out Void* data, out int byteStride) { }

	[Address(RVA = "0x10663A0", Offset = "0x10655A0", Length = "0x135")]
	[AsyncStateMachine(typeof(<InstantiateMainSceneAsync>d__66))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyBodyParts>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateMainSceneAsync>d__66)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateMainSceneAsync>d__66&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public Task<Boolean> InstantiateMainSceneAsync(Transform parent, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1066260", Offset = "0x1065460", Length = "0x135")]
	[AsyncStateMachine(typeof(<InstantiateMainSceneAsync>d__67))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<ImportMeshAsync>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAssetBase+<Instantiate>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InstantiateMainSceneAsync>d__66), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateMainSceneAsync>d__67)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateMainSceneAsync>d__67&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	public Task<Boolean> InstantiateMainSceneAsync(IInstantiator instantiator, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x10664E0", Offset = "0x10656E0", Length = "0x12A")]
	[AsyncStateMachine(typeof(<InstantiateSceneAsync>d__69))]
	[CalledBy(Type = "GLTFast.GltfAssetBase+<InstantiateScene>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAssetBase+<InstantiateScene>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InstantiateMainSceneAsync>d__67), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateSceneAsync>d__69)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateSceneAsync>d__69&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	public Task<Boolean> InstantiateSceneAsync(IInstantiator instantiator, int sceneIndex = 0, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1066610", Offset = "0x1065810", Length = "0x135")]
	[AsyncStateMachine(typeof(<InstantiateSceneInternal>d__124))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateSceneInternal>d__124)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InstantiateSceneInternal>d__124&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B3")]
	private Task InstantiateSceneInternal(RootBase gltf, IInstantiator instantiator, int sceneId) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	public override bool IsTextureYFlipped(int index = 0) { }

	[Address(RVA = "0x1067520", Offset = "0x1066720", Length = "0x15B")]
	[AsyncStateMachine(typeof(<Load>d__57))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	public Task<Boolean> Load(Uri url, ImportSettings importSettings = null, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x10673C0", Offset = "0x10665C0", Length = "0x15B")]
	[AsyncStateMachine(typeof(<Load>d__56))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyBodyParts>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.MeshPartLoadController+<ImportMeshAsync>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAssetBase+<Load>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset+<Load>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__56)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Load>d__56&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	public Task<Boolean> Load(string url, ImportSettings importSettings = null, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1066750", Offset = "0x1065950", Length = "0x13D")]
	[AsyncStateMachine(typeof(<LoadAccessorData>d__140))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAccessorData>d__140)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAccessorData>d__140&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	private Task<Boolean> LoadAccessorData(RootBase gltf) { }

	[Address(RVA = "0x1066890", Offset = "0x1065A90", Length = "0xE1")]
	[CalledBy(Type = typeof(<ParseJsonAndLoadBuffers>d__101), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A4")]
	private void LoadBuffer(int index, Uri url) { }

	[Address(RVA = "0x1066980", Offset = "0x1065B80", Length = "0xEA")]
	[AsyncStateMachine(typeof(<LoadContent>d__99))]
	[CalledBy(Type = typeof(<LoadFromUri>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadContent>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadContent>d__99&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	private Task<Boolean> LoadContent() { }

	[Address(RVA = "0x1066A70", Offset = "0x1065C70", Length = "0x13D")]
	[AsyncStateMachine(typeof(<LoadFromUri>d__98))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadFromUri>d__98)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadFromUri>d__98&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	private Task<Boolean> LoadFromUri(Uri url, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1066D00", Offset = "0x1065F00", Length = "0x145")]
	[AsyncStateMachine(typeof(<LoadGltf>d__104))]
	[CalledBy(Type = typeof(<LoadFromUri>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadGltf>d__104)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadGltf>d__104&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009F")]
	private Task<Boolean> LoadGltf(string json, Uri url) { }

	[Address(RVA = "0x1066BB0", Offset = "0x1065DB0", Length = "0x144")]
	[AsyncStateMachine(typeof(<LoadGltfBinaryBuffer>d__114))]
	[CalledBy(Type = typeof(<LoadFromUri>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadGltfBinaryBuffer>d__114)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadGltfBinaryBuffer>d__114&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	private Task<Boolean> LoadGltfBinaryBuffer(Byte[] bytes, Uri uri = null) { }

	[Address(RVA = "0x1066FD0", Offset = "0x10661D0", Length = "0x2F5")]
	[CalledBy(Type = typeof(<LoadImages>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureDownload`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A7")]
	private void LoadImage(int imageIndex, Uri url, bool nonReadable, bool isKtx) { }

	[Address(RVA = "0x1066E50", Offset = "0x1066050", Length = "0x130")]
	[AsyncStateMachine(typeof(<LoadImageFromBuffer>d__106))]
	[CalledBy(Type = typeof(<LoadImages>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadImageFromBuffer>d__106)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadImageFromBuffer>d__106&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	private Task LoadImageFromBuffer(Task<Tuple`2<Byte[], String>> decodeBufferTask, int imageIndex, Image img) { }

	[Address(RVA = "0x1066F80", Offset = "0x1066180", Length = "0x4A")]
	[CalledBy(Type = typeof(<WaitForTextureDownloads>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000A8")]
	private bool LoadImageFromBytes(int imageIndex) { }

	[Address(RVA = "0x10672D0", Offset = "0x10664D0", Length = "0xEC")]
	[AsyncStateMachine(typeof(<LoadImages>d__105))]
	[CalledBy(Type = typeof(<LoadGltf>d__104), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadGltfBinaryBuffer>d__114), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadImages>d__105)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadImages>d__105&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A0")]
	private Task LoadImages(Uri baseUri) { }

	[Token(Token = "0x600009B")]
	protected abstract RootBase ParseJson(string json) { }

	[Address(RVA = "0x1067680", Offset = "0x1066880", Length = "0x141")]
	[AsyncStateMachine(typeof(<ParseJsonAndLoadBuffers>d__101))]
	[CalledBy(Type = typeof(<LoadGltf>d__104), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadGltfBinaryBuffer>d__114), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseJsonAndLoadBuffers>d__101)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseJsonAndLoadBuffers>d__101&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	private Task<Boolean> ParseJsonAndLoadBuffers(string json, Uri baseUri) { }

	[Address(RVA = "0x1067CC0", Offset = "0x1066EC0", Length = "0x106")]
	[AsyncStateMachine(typeof(<Prepare>d__118))]
	[CalledBy(Type = typeof(<LoadFromUri>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Prepare>d__118)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Prepare>d__118&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AD")]
	private Task<Boolean> Prepare() { }

	[Address(RVA = "0x10677D0", Offset = "0x10669D0", Length = "0x4D4")]
	[CalledBy(Type = typeof(<CreatePrimitiveContexts>d__143), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32FlippedJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32FlippedJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32Job)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateIndicesInt32Job), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PrimitiveCreateContext), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C1")]
	private void PreparePrimitiveIndices(RootBase gltf, MeshPrimitiveBase primitive, ref PrimitiveCreateContext c, int subMesh = 0) { }

	[Address(RVA = "0x6B5D30", Offset = "0x6B4F30", Length = "0xB0")]
	[CalledBy(Type = typeof(GltfImportBase), Member = "GetScalarJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RootBase), typeof(int), typeof(Nullable`1<NativeArray`1<Single>>&), typeof(Nullable`1<JobHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B6")]
	private static NativeArray<T> Reinterpret(NativeSlice<Byte> slice, int count, int offset = 0) { }

	[Address(RVA = "0x1067DD0", Offset = "0x1066FD0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000BB")]
	private static void SafeDestroy(object obj) { }

	[Address(RVA = "0x1068D90", Offset = "0x1067F90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000082")]
	private void set_LoadingDone(bool value) { }

	[Address(RVA = "0x1068DA0", Offset = "0x1067FA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000084")]
	private void set_LoadingError(bool value) { }

	[Token(Token = "0x6000080")]
	protected abstract void set_Root(RootBase value) { }

	[Address(RVA = "0x1067E20", Offset = "0x1067020", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000BE")]
	private void SetAccessorUsage(int index, AccessorUsage newUsage) { }

	[Address(RVA = "0x1067E50", Offset = "0x1067050", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000086")]
	public static void SetDefaultDeferAgent(IDeferAgent deferAgent) { }

	[Address(RVA = "0x1067EC0", Offset = "0x10670C0", Length = "0xB5")]
	[CalledBy(Type = typeof(<LoadAccessorData>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AE")]
	private void SetMaterialPointsSupport(int materialIndex) { }

	[Address(RVA = "0x10684A0", Offset = "0x10676A0", Length = "0x96")]
	[CalledBy(Type = typeof(UninterruptedDefaultDeferAgent), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000087")]
	public static void UnsetDefaultDeferAgent(IDeferAgent deferAgent) { }

	[Address(RVA = "0x1068540", Offset = "0x1067740", Length = "0x111")]
	[AsyncStateMachine(typeof(<WaitForBufferDownloads>d__107))]
	[CalledBy(Type = typeof(<LoadContent>d__99), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForBufferDownloads>d__107)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForBufferDownloads>d__107&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	private Task<Boolean> WaitForBufferDownloads() { }

	[Address(RVA = "0x1068660", Offset = "0x1067860", Length = "0x111")]
	[AsyncStateMachine(typeof(<WaitForTextureDownloads>d__108))]
	[CalledBy(Type = typeof(<LoadContent>d__99), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForTextureDownloads>d__108)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForTextureDownloads>d__108&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	private Task<Boolean> WaitForTextureDownloads() { }

}

