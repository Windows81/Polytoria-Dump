namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20005CC")]
public class Dictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20005CD")]
	private struct Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001845")]
		public int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001846")]
		public int next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001847")]
		public TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001848")]
		public TValue value; //Field offset: 0x0

	}

	[Token(Token = "0x20005CE")]
	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001849")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184A")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184B")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184C")]
		private KeyValuePair<TKey, TValue> _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184D")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x170006AA")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AC8")]
			 get { } //Length: 19
		}

		[Token(Token = "0x170006AC")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0xB22250", Offset = "0xB21450", Length = "0xF0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ACC")]
			private get { } //Length: 240
		}

		[Token(Token = "0x170006AD")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0xB22AB0", Offset = "0xB21CB0", Length = "0x84")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ACD")]
			private get { } //Length: 132
		}

		[Token(Token = "0x170006AE")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0xB23220", Offset = "0xB22420", Length = "0x82")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ACE")]
			private get { } //Length: 130
		}

		[Token(Token = "0x170006AB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB24580", Offset = "0xB23780", Length = "0x1D5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ACA")]
			private get { } //Length: 469
		}

		[Address(RVA = "0xB263E0", Offset = "0xB255E0", Length = "0x53")]
		[CalledBy(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC6")]
		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC9")]
		public override void Dispose() { }

		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC8")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0xB21900", Offset = "0xB20B00", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC7")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB22250", Offset = "0xB21450", Length = "0xF0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACC")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0xB22AB0", Offset = "0xB21CB0", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACD")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0xB23220", Offset = "0xB22420", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACE")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0xB24580", Offset = "0xB23780", Length = "0x1D5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB23950", Offset = "0xB22B50", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACB")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[Token(Token = "0x20005CF")]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[Token(Token = "0x20005D0")]
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400184F")]
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001850")]
			private int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001851")]
			private int _version; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001852")]
			private TKey _currentKey; //Field offset: 0x0

			[Token(Token = "0x170006B2")]
			public override TKey Current
			{
				[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
				[CallerCount(Count = 50)]
				[DeduplicatedMethod]
				[Token(Token = "0x6002ADF")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170006B3")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xB24250", Offset = "0xB23450", Length = "0x72")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
				[DeduplicatedMethod]
				[Token(Token = "0x6002AE0")]
				private get { } //Length: 114
			}

			[Address(RVA = "0xB25DF0", Offset = "0xB24FF0", Length = "0x40")]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ADC")]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ADD")]
			public override void Dispose() { }

			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ADF")]
			public override TKey get_Current() { }

			[Address(RVA = "0xB20680", Offset = "0xB1F880", Length = "0x9B")]
			[CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Claim), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.DynamicHeightVirtualizationController`1", Member = "CleanItemHeightCache", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "SynchronizeMaterials", ReturnType = typeof(void))]
			[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
			[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileLambdaExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "ReleasePointerDrags", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "InitBundles", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.TerrainUtils.TerrainMap", Member = "Validate", ReturnType = "UnityEngine.TerrainUtils.TerrainMapStatusCode")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ADE")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB24250", Offset = "0xB23450", Length = "0x72")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AE0")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0xB237A0", Offset = "0xB229A0", Length = "0x38")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AE1")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184E")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x170006AF")]
		public override int Count
		{
			[Address(RVA = "0x855BB0", Offset = "0x854DB0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AD2")]
			 get { } //Length: 42
		}

		[Token(Token = "0x170006B0")]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AD3")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006B1")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xCD6590", Offset = "0xCD5790", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002ADB")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x855B60", Offset = "0x854D60", Length = "0x42")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ACF")]
		public KeyCollection(Dictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0xCC96C0", Offset = "0xCC88C0", Length = "0x11A")]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD1")]
		public override void CopyTo(TKey[] array, int index) { }

		[Address(RVA = "0x855BB0", Offset = "0x854DB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD2")]
		public override int get_Count() { }

		[Address(RVA = "0x853530", Offset = "0x852730", Length = "0x36")]
		[CallerCount(Count = 61)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD0")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xCCA570", Offset = "0xCC9770", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD4")]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[Address(RVA = "0xCCA570", Offset = "0xCC9770", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD5")]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[Address(RVA = "0xCCAB70", Offset = "0xCC9D70", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD6")]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD3")]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[Address(RVA = "0xCCAC80", Offset = "0xCC9E80", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD7")]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[Address(RVA = "0x8538B0", Offset = "0x852AB0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD8")]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[Address(RVA = "0xCD1E40", Offset = "0xCD1040", Length = "0x33B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ADA")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0xCD6590", Offset = "0xCD5790", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ADB")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x8538B0", Offset = "0x852AB0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AD9")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[Token(Token = "0x20005D1")]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[Token(Token = "0x20005D2")]
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001854")]
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001855")]
			private int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001856")]
			private int _version; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001857")]
			private TValue _currentValue; //Field offset: 0x0

			[Token(Token = "0x170006B7")]
			public override TValue Current
			{
				[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
				[CallerCount(Count = 9)]
				[DeduplicatedMethod]
				[Token(Token = "0x6002AF2")]
				 get { } //Length: 4
			}

			[Token(Token = "0x170006B8")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xB241D0", Offset = "0xB233D0", Length = "0x70")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
				[DeduplicatedMethod]
				[Token(Token = "0x6002AF3")]
				private get { } //Length: 112
			}

			[Address(RVA = "0xB25FD0", Offset = "0xB251D0", Length = "0x3F")]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AEF")]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF0")]
			public override void Dispose() { }

			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF2")]
			public override TValue get_Current() { }

			[Address(RVA = "0xB208A0", Offset = "0xB1FAA0", Length = "0x95")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF1")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB241D0", Offset = "0xB233D0", Length = "0x70")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF3")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0xB23760", Offset = "0xB22960", Length = "0x37")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF4")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001853")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x170006B4")]
		public override int Count
		{
			[Address(RVA = "0x855BB0", Offset = "0x854DB0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AE5")]
			 get { } //Length: 42
		}

		[Token(Token = "0x170006B5")]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AE6")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006B6")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x855B10", Offset = "0x854D10", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AEE")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x855B60", Offset = "0x854D60", Length = "0x42")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE2")]
		public ValueCollection(Dictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x852BF0", Offset = "0x851DF0", Length = "0x119")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE4")]
		public override void CopyTo(TValue[] array, int index) { }

		[Address(RVA = "0x855BB0", Offset = "0x854DB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE5")]
		public override int get_Count() { }

		[Address(RVA = "0x853570", Offset = "0x852770", Length = "0x36")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE3")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0x853630", Offset = "0x852830", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE7")]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[Address(RVA = "0x853630", Offset = "0x852830", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE9")]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[Address(RVA = "0x8537E0", Offset = "0x8529E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEA")]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE6")]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[Address(RVA = "0x853810", Offset = "0x852A10", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE8")]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[Address(RVA = "0x853920", Offset = "0x852B20", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEB")]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[Address(RVA = "0x8551A0", Offset = "0x8543A0", Length = "0x339")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AED")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x855B10", Offset = "0x854D10", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEE")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x853920", Offset = "0x852B20", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEC")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400183B")]
	private Int32[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400183C")]
	private Entry<TKey, TValue>[] _entries; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400183D")]
	private int _count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400183E")]
	private int _freeList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400183F")]
	private int _freeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001840")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001841")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001842")]
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001843")]
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001844")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x1700069F")]
	public override int Count
	{
		[Address(RVA = "0x9F5130", Offset = "0x9F4330", Length = "0x7")]
		[CallerCount(Count = 87)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A9C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170006A6")]
	public override TValue Item
	{
		[Address(RVA = "0x9F5140", Offset = "0x9F4340", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AA3")]
		 get { } //Length: 161
		[Address(RVA = "0x9F5530", Offset = "0x9F4730", Length = "0x28")]
		[CalledBy(Type = "Mirror.MultiplexTransport", Member = "AddToLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AA4")]
		 set { } //Length: 40
	}

	[Token(Token = "0x170006A0")]
	public KeyCollection<TKey, TValue> Keys
	{
		[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A9D")]
		 get { } //Length: 154
	}

	[Token(Token = "0x170006A7")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ABA")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006A1")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A9E")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006A4")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
		[CallerCount(Count = 75)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AA1")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006A2")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A9F")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006A5")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
		[CallerCount(Count = 75)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AA2")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006A8")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x9F01F0", Offset = "0x9EF3F0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002ABF")]
		private get { } //Length: 104
	}

	[Token(Token = "0x170006A9")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x9F1430", Offset = "0x9F0630", Length = "0x142")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC0")]
		private get { } //Length: 322
		[Address(RVA = "0x9F1770", Offset = "0x9F0970", Length = "0x1D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AC1")]
		private set { } //Length: 465
	}

	[Token(Token = "0x170006A3")]
	public ValueCollection<TKey, TValue> Values
	{
		[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
		[CallerCount(Count = 75)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AA0")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x9F3E90", Offset = "0x9F3090", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A95")]
	public Dictionary`2() { }

	[Address(RVA = "0x9F3E70", Offset = "0x9F3070", Length = "0x16")]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800530B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A96")]
	public Dictionary`2(int capacity) { }

	[Address(RVA = "0x9F4FD0", Offset = "0x9F41D0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A97")]
	public Dictionary`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x9F4AC0", Offset = "0x9F3CC0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052790")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A98")]
	public Dictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x9F43C0", Offset = "0x9F35C0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A99")]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary) { }

	[Address(RVA = "0x9F3980", Offset = "0x9F2B80", Length = "0x3C9")]
	[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800530B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9A")]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x9F3D50", Offset = "0x9F2F50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object, System.Runtime.Serialization.SerializationInfo>))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9B")]
	protected Dictionary`2(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x9E89F0", Offset = "0x9E7BF0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA5")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0x9E8A60", Offset = "0x9E7C60", Length = "0x62")]
	[CallerCount(Count = 115)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA9")]
	public override void Clear() { }

	[Address(RVA = "0x9E8B50", Offset = "0x9E7D50", Length = "0x25")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAA")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0x9E8EE0", Offset = "0x9E80E0", Length = "0xC4")]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.Generic.ICollection<TValue>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "namudev.PropertyGrid", Member = "AppendProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAB")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0x9E9160", Offset = "0x9E8360", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAC")]
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x9E9790", Offset = "0x9E8990", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052C10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052790")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABE")]
	public int EnsureCapacity(int capacity) { }

	[Address(RVA = "0x9E9870", Offset = "0x9E8A70", Length = "0x3B4")]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB0")]
	private int FindEntry(TKey key) { }

	[Address(RVA = "0x9F5130", Offset = "0x9F4330", Length = "0x7")]
	[CallerCount(Count = 87)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9C")]
	public override int get_Count() { }

	[Address(RVA = "0x9F5140", Offset = "0x9F4340", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA3")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9D")]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA0")]
	public ValueCollection<TKey, TValue> get_Values() { }

	[Address(RVA = "0x9EA8B0", Offset = "0x9E9AB0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAD")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0x9EAB30", Offset = "0x9E9D30", Length = "0x1EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052240")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAF")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x9EB2C0", Offset = "0x9EA4C0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB1")]
	private int Initialize(int capacity) { }

	[Address(RVA = "0x9EB480", Offset = "0x9EA680", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC2")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0x9EC080", Offset = "0x9EB280", Length = "0x39D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052790")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object, System.Runtime.Serialization.SerializationInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB3")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x9ED510", Offset = "0x9EC710", Length = "0x236")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B2F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB6")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0x9EC9C0", Offset = "0x9EBBC0", Length = "0x254")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B2F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180053370")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB7")]
	public bool Remove(TKey key, out TValue value) { }

	[Address(RVA = "0x9EDE50", Offset = "0x9ED050", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB5")]
	private void Resize(int newSize, bool forceNewHashCodes) { }

	[Address(RVA = "0x9EDFB0", Offset = "0x9ED1B0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052C10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB4")]
	private void Resize() { }

	[Address(RVA = "0x9F5530", Offset = "0x9F4730", Length = "0x28")]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "AddToLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA4")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x9EE290", Offset = "0x9ED490", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA6")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9EE6C0", Offset = "0x9ED8C0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA7")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9EE7A0", Offset = "0x9ED9A0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABB")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABA")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0x9EE9C0", Offset = "0x9EDBC0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA8")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9E")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA1")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x9EED40", Offset = "0x9EDF40", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AAE")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0x9EEC00", Offset = "0x9EDE00", Length = "0x9A")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9F")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x9EECA0", Offset = "0x9EDEA0", Length = "0x9A")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AA2")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x9EFC70", Offset = "0x9EEE70", Length = "0x42C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052240")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABC")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x9F01F0", Offset = "0x9EF3F0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABF")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x9F0260", Offset = "0x9EF460", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC3")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x9F1430", Offset = "0x9F0630", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC0")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x9F0A30", Offset = "0x9EFC30", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC4")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x9F0C30", Offset = "0x9EFE30", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC5")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0x9F1770", Offset = "0x9F0970", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AC1")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x9EED40", Offset = "0x9EDF40", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002ABD")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x9F1DC0", Offset = "0x9F0FC0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB9")]
	public bool TryAdd(TKey key, TValue value) { }

	[Address(RVA = "0x9F2020", Offset = "0x9F1220", Length = "0x6C")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB8")]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[Address(RVA = "0x9F2CC0", Offset = "0x9F1EC0", Length = "0x55A")]
	[CalledBy(Type = typeof(Dictionary`2), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowAddingDuplicateWithKeyArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052790")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052C10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002AB2")]
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }

}

