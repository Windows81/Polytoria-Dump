namespace System.ComponentModel;

[Token(Token = "0x200018C")]
public sealed class TypeDescriptor
{
	[Token(Token = "0x200018D")]
	private sealed class FilterCacheItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000654")]
		private ITypeDescriptorFilterService _filterService; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000655")]
		internal ICollection FilteredMembers; //Field offset: 0x18

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009AD")]
		internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

		[Address(RVA = "0x179FB70", Offset = "0x179ED70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009AE")]
		internal bool IsValid(ITypeDescriptorFilterService filterService) { }

	}

	[Token(Token = "0x200018E")]
	private interface IUnimplemented
	{

	}

	[Token(Token = "0x200018F")]
	private sealed class MemberDescriptorComparer : IComparer
	{
		[Token(Token = "0x4000656")]
		public static readonly MemberDescriptorComparer Instance; //Field offset: 0x0

		[Address(RVA = "0x17A1A00", Offset = "0x17A0C00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60009B1")]
		private static MemberDescriptorComparer() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B0")]
		public MemberDescriptorComparer() { }

		[Address(RVA = "0x17A18C0", Offset = "0x17A0AC0", Length = "0x13A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60009AF")]
		public override int Compare(object left, object right) { }

	}

	[Token(Token = "0x2000190")]
	private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000657")]
		private ICustomTypeDescriptor _primary; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000658")]
		private ICustomTypeDescriptor _secondary; //Field offset: 0x18

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B2")]
		internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

		[Address(RVA = "0x17A2340", Offset = "0x17A1540", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009B3")]
		private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

		[Address(RVA = "0x17A23B0", Offset = "0x17A15B0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009B4")]
		private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	}

	[Token(Token = "0x2000191")]
	private sealed class TypeDescriptionNode : TypeDescriptionProvider
	{
		[Token(Token = "0x2000192")]
		private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400065B")]
			private TypeDescriptionNode _node; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400065C")]
			private object _instance; //Field offset: 0x8

			[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
			[CallerCount(Count = 48)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60009BA")]
			internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance) { }

			[Address(RVA = "0x179B820", Offset = "0x179AA20", Length = "0x311")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60009BB")]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[Address(RVA = "0x179BB40", Offset = "0x179AD40", Length = "0x30A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData")]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60009BC")]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

		}

		[Token(Token = "0x2000193")]
		private struct DefaultTypeDescriptor : ICustomTypeDescriptor
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400065D")]
			private TypeDescriptionNode _node; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400065E")]
			private Type _objectType; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400065F")]
			private object _instance; //Field offset: 0x10

			[Address(RVA = "0x89C9E0", Offset = "0x89BBE0", Length = "0x4F")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x60009BD")]
			internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance) { }

			[Address(RVA = "0x179BF40", Offset = "0x179B140", Length = "0x2E4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60009BE")]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[Address(RVA = "0x179C230", Offset = "0x179B430", Length = "0x2F3")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
			[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
			[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60009BF")]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

		}

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000659")]
		internal TypeDescriptionNode Next; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400065A")]
		internal TypeDescriptionProvider Provider; //Field offset: 0x28

		[Address(RVA = "0x595670", Offset = "0x594870", Length = "0x31")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B5")]
		internal TypeDescriptionNode(TypeDescriptionProvider provider) { }

		[Address(RVA = "0x17AA7B0", Offset = "0x17A99B0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009B6")]
		public virtual IDictionary GetCache(object instance) { }

		[Address(RVA = "0x17AA840", Offset = "0x17A9A40", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60009B7")]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

		[Address(RVA = "0x17AA910", Offset = "0x17A9B10", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009B8")]
		public virtual Type GetReflectionType(Type objectType, object instance) { }

		[Address(RVA = "0x17AA9D0", Offset = "0x17A9BD0", Length = "0x19A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009B9")]
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	}

	[Token(Token = "0x2000194")]
	[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private sealed class TypeDescriptorComObject
	{

	}

	[Token(Token = "0x2000195")]
	private sealed class TypeDescriptorInterface
	{

	}

	[Token(Token = "0x4000648")]
	private static WeakHashtable _providerTable; //Field offset: 0x0
	[Token(Token = "0x4000649")]
	private static Hashtable _providerTypeTable; //Field offset: 0x8
	[Token(Token = "0x400064A")]
	private static Hashtable _defaultProviders; //Field offset: 0x10
	[Token(Token = "0x400064B")]
	private static int _metadataVersion; //Field offset: 0x18
	[Token(Token = "0x400064C")]
	private static int _collisionIndex; //Field offset: 0x1C
	[Token(Token = "0x400064D")]
	private static BooleanSwitch TraceDescriptor; //Field offset: 0x20
	[Token(Token = "0x400064E")]
	private static readonly Guid[] _pipelineInitializeKeys; //Field offset: 0x28
	[Token(Token = "0x400064F")]
	private static readonly Guid[] _pipelineMergeKeys; //Field offset: 0x30
	[Token(Token = "0x4000650")]
	private static readonly Guid[] _pipelineFilterKeys; //Field offset: 0x38
	[Token(Token = "0x4000651")]
	private static readonly Guid[] _pipelineAttributeFilterKeys; //Field offset: 0x40
	[Token(Token = "0x4000652")]
	private static object _internalSyncObject; //Field offset: 0x48
	[CompilerGenerated]
	[Token(Token = "0x4000653")]
	private static RefreshEventHandler Refreshed; //Field offset: 0x50

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x170001CB")]
	public static Type ComObjectType
	{
		[Address(RVA = "0x17AFB20", Offset = "0x17AED20", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000991")]
		 get { } //Length: 77
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x170001CC")]
	public static Type InterfaceType
	{
		[Address(RVA = "0x17AFB70", Offset = "0x17AED70", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000992")]
		 get { } //Length: 77
	}

	[Token(Token = "0x170001CD")]
	internal static int MetadataVersion
	{
		[Address(RVA = "0x17AFBC0", Offset = "0x17AEDC0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000993")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x17AF660", Offset = "0x17AE860", Length = "0x4B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(BooleanSwitch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009AC")]
	private static TypeDescriptor() { }

	[Address(RVA = "0x17AAE80", Offset = "0x17AA080", Length = "0x2AE")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000994")]
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	[Address(RVA = "0x17AB130", Offset = "0x17AA330", Length = "0x690")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000995")]
	private static void CheckDefaultProvider(Type type) { }

	[Address(RVA = "0x17AFB20", Offset = "0x17AED20", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000991")]
	public static Type get_ComObjectType() { }

	[Address(RVA = "0x17AFB70", Offset = "0x17AED70", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000992")]
	public static Type get_InterfaceType() { }

	[Address(RVA = "0x17AFBC0", Offset = "0x17AEDC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000993")]
	internal static int get_MetadataVersion() { }

	[Address(RVA = "0x17ABBA0", Offset = "0x17AADA0", Length = "0xDB")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000996")]
	public static AttributeCollection GetAttributes(Type componentType) { }

	[Address(RVA = "0x17ABB50", Offset = "0x17AAD50", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[Token(Token = "0x6000997")]
	public static AttributeCollection GetAttributes(object component) { }

	[Address(RVA = "0x17AB7D0", Offset = "0x17AA9D0", Length = "0x379")]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeConverter))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000998")]
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	[Address(RVA = "0x17ABC80", Offset = "0x17AAE80", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000999")]
	internal static IDictionary GetCache(object instance) { }

	[Address(RVA = "0x17ABD30", Offset = "0x17AAF30", Length = "0x87")]
	[CalledBy(Type = "Battlehub.Reflection", Member = "TryConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099A")]
	public static TypeConverter GetConverter(Type type) { }

	[Address(RVA = "0x17AC050", Offset = "0x17AB250", Length = "0x113")]
	[CalledBy(Type = typeof(NullableConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600099B")]
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	[Address(RVA = "0x17ABDC0", Offset = "0x17AAFC0", Length = "0x284")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600099C")]
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	[Address(RVA = "0x17AC170", Offset = "0x17AB370", Length = "0xEF")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600099D")]
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	[Address(RVA = "0x17AC260", Offset = "0x17AB460", Length = "0x229")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ICollection), typeof(object), typeof(IDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600099E")]
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	[Address(RVA = "0x17AC490", Offset = "0x17AB690", Length = "0x153")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600099F")]
	private static Type GetNodeForBaseType(Type searchType) { }

	[Address(RVA = "0x17AC5F0", Offset = "0x17AB7F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Token(Token = "0x60009A0")]
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[Address(RVA = "0x17AC640", Offset = "0x17AB840", Length = "0x113")]
	[CalledBy(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x60009A1")]
	public static Type GetReflectionType(Type type) { }

	[Address(RVA = "0x17AC9D0", Offset = "0x17ABBD0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60009A2")]
	private static TypeDescriptionNode NodeFor(Type type) { }

	[Address(RVA = "0x17ACA20", Offset = "0x17ABC20", Length = "0x595")]
	[CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
	[CalledBy(Type = typeof(EnumConverter), Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext)}, ReturnType = typeof(StandardValuesCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetProviderRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeDescriptionProvider))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetNodeForBaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60009A3")]
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	[Address(RVA = "0x17AC980", Offset = "0x17ABB80", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(TypeDescriptionNode))]
	[Token(Token = "0x60009A4")]
	private static TypeDescriptionNode NodeFor(object instance) { }

	[Address(RVA = "0x17AC760", Offset = "0x17AB960", Length = "0x215")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ICustomTypeDescriptor))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(TypeDescriptionNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60009A5")]
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	[Address(RVA = "0x17ACFC0", Offset = "0x17AC1C0", Length = "0x1083")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetExtenderCollisionSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberDescriptor)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OrderedDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60009A6")]
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	[Address(RVA = "0x17AE050", Offset = "0x17AD250", Length = "0x3C2")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60009A7")]
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	[Address(RVA = "0x17AE420", Offset = "0x17AD620", Length = "0xB02")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x60009A8")]
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	[Address(RVA = "0x17AEF30", Offset = "0x17AE130", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009A9")]
	private static void RaiseRefresh(Type type) { }

	[Address(RVA = "0x17AF020", Offset = "0x17AE220", Length = "0x562")]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDescriptionProvider), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60009AA")]
	public static void Refresh(Type type) { }

	[Address(RVA = "0x17AF590", Offset = "0x17AE790", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArrayList), Member = "Adapter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009AB")]
	public static void SortDescriptorArray(IList infos) { }

}

