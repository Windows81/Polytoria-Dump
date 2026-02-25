namespace SimpleJSON;

[DefaultMember("Item")]
[Token(Token = "0x2000031")]
public class JSONObject : JSONNode
{
	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000182")]
		public JSONNode aNode; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000416")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x314110", Offset = "0x313310", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000417")]
		internal bool <Remove>b__0(KeyValuePair<String, JSONNode> k) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000183")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000184")]
		private JSONNode <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000185")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000186")]
		public JSONObject <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000187")]
		private Enumerator<String, JSONNode> <>7__wrap1; //Field offset: 0x30

		[Token(Token = "0x17000063")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600041C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000064")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600041E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000418")]
		public <get_Children>d__23(int <>1__state) { }

		[Address(RVA = "0x314B30", Offset = "0x313D30", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600041B")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x3147E0", Offset = "0x3139E0", Length = "0x1D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5A40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600041A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3149C0", Offset = "0x313BC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600041F")]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600041C")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[Address(RVA = "0x3149C0", Offset = "0x313BC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000420")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600041E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x314A60", Offset = "0x313C60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600041D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x314AA0", Offset = "0x313CA0", Length = "0x83")]
		[CalledBy(Type = typeof(UnitySourceGeneratedAssemblyMonoScriptTypes_v1), Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5980")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6000419")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000180")]
	private Dictionary<String, JSONNode> m_Dict; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000181")]
	private bool inline; //Field offset: 0x18

	[Token(Token = "0x17000062")]
	public virtual IEnumerable<JSONNode> Children
	{
		[Address(RVA = "0x3006A0", Offset = "0x2FF8A0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<get_Children>d__23))]
		[Token(Token = "0x6000413")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000061")]
	public virtual int Count
	{
		[Address(RVA = "0x300720", Offset = "0x2FF920", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600040E")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700005C")]
	public virtual bool Inline
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000405")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000406")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005E")]
	public virtual bool IsObject
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000408")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005F")]
	public virtual JSONNode Item
	{
		[Address(RVA = "0x300810", Offset = "0x2FFA10", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600040A")]
		 get { } //Length: 220
		[Address(RVA = "0x300A00", Offset = "0x2FFC00", Length = "0xEE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600040B")]
		 set { } //Length: 238
	}

	[Token(Token = "0x17000060")]
	public virtual JSONNode Item
	{
		[Address(RVA = "0x300770", Offset = "0x2FF970", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600040C")]
		 get { } //Length: 154
		[Address(RVA = "0x300900", Offset = "0x2FFB00", Length = "0xFA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600040D")]
		 set { } //Length: 250
	}

	[Token(Token = "0x1700005D")]
	public virtual JSONNodeType Tag
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000407")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300620", Offset = "0x2FF820", Length = "0x77")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONNode), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "get_AsObject", ReturnType = typeof(JSONObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000415")]
	public JSONObject() { }

	[Address(RVA = "0x2FFE50", Offset = "0x2FF050", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040F")]
	public virtual void Add(string aKey, JSONNode aItem) { }

	[Address(RVA = "0x3006A0", Offset = "0x2FF8A0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<get_Children>d__23))]
	[Token(Token = "0x6000413")]
	public virtual IEnumerable<JSONNode> get_Children() { }

	[Address(RVA = "0x300720", Offset = "0x2FF920", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040E")]
	public virtual int get_Count() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	public virtual bool get_Inline() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000408")]
	public virtual bool get_IsObject() { }

	[Address(RVA = "0x300810", Offset = "0x2FFA10", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600040A")]
	public virtual JSONNode get_Item(string aKey) { }

	[Address(RVA = "0x300770", Offset = "0x2FF970", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040C")]
	public virtual JSONNode get_Item(int aIndex) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000407")]
	public virtual JSONNodeType get_Tag() { }

	[Address(RVA = "0x2FFF90", Offset = "0x2FF190", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000409")]
	public virtual Enumerator GetEnumerator() { }

	[Address(RVA = "0x300040", Offset = "0x2FF240", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000410")]
	public virtual JSONNode Remove(string aKey) { }

	[Address(RVA = "0x300260", Offset = "0x2FF460", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000411")]
	public virtual JSONNode Remove(int aIndex) { }

	[Address(RVA = "0x300110", Offset = "0x2FF310", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000412")]
	public virtual JSONNode Remove(JSONNode aNode) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000406")]
	public virtual void set_Inline(bool value) { }

	[Address(RVA = "0x300A00", Offset = "0x2FFC00", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040B")]
	public virtual void set_Item(string aKey, JSONNode value) { }

	[Address(RVA = "0x300900", Offset = "0x2FFB00", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040D")]
	public virtual void set_Item(int aIndex, JSONNode value) { }

	[Address(RVA = "0x300330", Offset = "0x2FF530", Length = "0x2E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(JSONNode), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000414")]
	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

