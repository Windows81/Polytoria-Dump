using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GLTFast;
using GLTFast.Logging;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class MeshPartLoadController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetMeshUrlAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public int assetID;

			private HttpClient _003Cclient_003E5__2;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CImportMeshAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			public MeshPartLoadController _003C_003E4__this;

			public string meshUrl;

			public MeshPartLoadRequest request;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private GameObject _003CloadedObject_003E5__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadMeshAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MeshPartLoadController _003C_003E4__this;

			public MeshPartLoadRequest request;

			private GameObject _003CloadedObject_003E5__2;

			private TaskAwaiter<string> _003C_003Eu__1;

			private TaskAwaiter<GameObject> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static MeshPartLoadController Instance;

		private Queue<MeshPartLoadRequest> loadQueue;

		private GameObject meshStorage;

		private bool loading;

		[SerializeField]
		private ImportSettings importSettings;

		[SerializeField]
		private InstantiationSettings instantiationSettings;

		private ConsoleLogger logger;

		public GltfImport Importer { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void LoadMesh(MeshPartLoadRequest request)
		{
		}

		private void Update()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadMeshAsync_003Ed__15))]
		private Task LoadMeshAsync(MeshPartLoadRequest request)
		{
			return null;
		}

		private GameObject FindInCache(int assetID)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMeshUrlAsync_003Ed__17))]
		private Task<string> GetMeshUrlAsync(int assetID)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CImportMeshAsync_003Ed__18))]
		private Task<GameObject> ImportMeshAsync(MeshPartLoadRequest request, string meshUrl)
		{
			return null;
		}

		private void CacheLoadedObject(int assetID, GameObject loadedObject)
		{
		}

		private void ProcessLoadedObject(MeshPartLoadRequest request, GameObject loadedObject)
		{
		}

		private void ClearExistingChildren(MeshPart meshPart)
		{
		}

		private void AdjustLoadedObjectBounds(GameObject loadedObject)
		{
		}

		private void AttachLoadedObjectToMeshPart(MeshPartLoadRequest request, GameObject loadedObject)
		{
		}

		private void EnableRenderers(GameObject obj, bool enabled)
		{
		}
	}
}
