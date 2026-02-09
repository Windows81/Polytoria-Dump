using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class LoadScreenController : MonoBehaviour
	{
		public static LoadScreenController singleton;

		[SerializeField]
		private Image progressBar;

		[SerializeField]
		private GameObject progressBarContainer;

		[SerializeField]
		private TMP_Text gameName;

		[SerializeField]
		private TMP_Text loadingStatus;

		public bool IsLoadingMap { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void GameLoaded()
		{
		}

		public void SetStatus(string status)
		{
		}

		public void SetGameInfo(string name)
		{
		}

		private void Update()
		{
		}
	}
}
