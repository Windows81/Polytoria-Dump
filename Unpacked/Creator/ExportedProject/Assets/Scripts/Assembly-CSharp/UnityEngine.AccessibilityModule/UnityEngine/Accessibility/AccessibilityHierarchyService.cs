namespace UnityEngine.Accessibility;

[Token(Token = "0x2000013")]
internal class AccessibilityHierarchyService : IService
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000062")]
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x10

	[Token(Token = "0x17000032")]
	internal AccessibilityHierarchy hierarchy
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000083")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public AccessibilityHierarchyService() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000083")]
	internal AccessibilityHierarchy get_hierarchy() { }

	[Address(RVA = "0x18FB1B0", Offset = "0x18FA3B0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000088")]
	internal List<AccessibilityNode> GetRootNodes() { }

	[Address(RVA = "0x18FB1D0", Offset = "0x18FA3D0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	private void RemoveActiveHierarchy(bool notifyScreenChanged) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000084")]
	public override void Start() { }

	[Address(RVA = "0x18FB320", Offset = "0x18FA520", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	public override void Stop() { }

	[Address(RVA = "0x18FB4F0", Offset = "0x18FA6F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000087")]
	internal bool TryGetNode(int id, out AccessibilityNode node) { }

	[Address(RVA = "0x18FB460", Offset = "0x18FA660", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000089")]
	internal bool TryGetNodeAt(float x, float y, out AccessibilityNode node) { }

}

