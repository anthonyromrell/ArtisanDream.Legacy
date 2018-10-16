using ArtisanDream.Tools.Objects;
using UnityEngine;
using UnityEngine.UI;

namespace ArtisanDream.Tools.Examples
{
	public class HealthBehaviour : MonoBehaviour
	{
		public FloatBase HealthLevel;
		private Image healthImage;
	
		// Use this for initialization
		void Start ()
		{
			healthImage = GetComponent<Image>();
		}
	
		// Update is called once per frame
		void Update ()
		{
			healthImage.fillAmount = HealthLevel.Value;
		}
	}
}