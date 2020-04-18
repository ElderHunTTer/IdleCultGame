using UnityEngine;
using UnityEngine.UI;

public class IdleGame : MonoBehaviour
{
    //Cultivation Base Text
	public Text cultivationText;
	// Cultivation #
	public double cultivation;
	public double cultivationPowerValue;
	public double cultivationPerSec;
	//Texts Boxes
	public Text cultivationPerSecText;
	public Text bodyUpgradeText;
	//Body Upgrading
	public Text clickPowerText;
	public double bodyUpgradeCost;
	public int bodyUpgradeLevel;
	//realm Upgrading
	public Text realmUpgradeText;
	public double realmUpgradeCost;
	public int realmUpgradeLevel;
	//Soul Uprgading
	public Text soulUpgradeText;
	public double soulUpgradeCost;
	public int soulLevel;
	//Player Stats
	public double statHealth;
	public double statQi;
	public double statStrength;
	public double statStamina;
	public double statAgility;
	public double statBreath;
	public double statSpirit;
	public double statPerception;
	public double statLuck;

	//Player Stats TEXT
	public Text statHealthText;
	public Text statQiText;
	public Text statStrengthText;
	public Text statStaminaText;
	public Text statAgilityText;
	public Text statBreathText;
	public Text statSpiritText;
	public Text statPerceptionText;
	public Text statLuckText;


	//Starting
	public void Start()
	{
		cultivationPowerValue = 1;
		bodyUpgradeCost = 5;
		realmUpgradeCost = 3;
		soulUpgradeCost = 10;
	}	
	
	//Updating The Cultivation
	
	public void Update()
	{
		//Culti Per Second MAth
		cultivationPerSec = realmUpgradeLevel + soulLevel * 5;

		// Text Stuff
		clickPowerText.text = "Enlighten\n+" + cultivationPowerValue + "Culti";
		cultivationText.text = "Cultivation: " + cultivation.ToString("F0");
		cultivationPerSecText.text = cultivationPerSec.ToString("F0") + " Culti/Sec";
		bodyUpgradeText.text = "Body Tempering\nCosts: " + bodyUpgradeCost.ToString("F0") + " Cultivation\nPower + 1\n Level " + bodyUpgradeLevel;
		realmUpgradeText.text = "Realm Upgrade\nCosts: " + realmUpgradeCost.ToString("F0") + " Cultivation\n+2 Cultivation Per Sec\nLevel " + realmUpgradeLevel;
		soulUpgradeText.text = "Soul Refine\nCosts: " + soulUpgradeCost.ToString("F0") + " Cultivation\n+5 Cultivation Per Sec\nLevel " + soulLevel;

		//Stats
		//Stength
		statStrength = bodyUpgradeLevel * 5 + soulLevel;
		statStrengthText.text = "Strength " + statStrength;
		//Stamina
		statStamina = bodyUpgradeLevel * 5 + soulLevel;
		statStaminaText.text = "Stamina " + statStamina;
		//Agility
		statAgility = bodyUpgradeLevel * 5 + soulLevel;
		statAgilityText.text = "Agility " + statAgility;
		//Breath
		statBreath = bodyUpgradeLevel * 5 + soulLevel;
		statBreathText.text = "Breath " + statBreath;
		//Spirit
		statSpirit = bodyUpgradeLevel * 5 + soulLevel;
		statSpiritText.text = "Spirit " + statSpirit;
		//Perception
		statPerception = bodyUpgradeLevel * 5 + soulLevel;
		statPerceptionText.text = "Perception " + statPerception;
		//Luck
		statLuck = bodyUpgradeLevel * 5 + soulLevel;
		statLuckText.text = "Luck " + statLuck;

		//Usetime instead of Framerate idea by Troy >.>
		//Cultivation

		cultivation += cultivationPerSec * Time.deltaTime;
	}

	public void Click()
    {
		cultivation += cultivationPowerValue;
	}

	//Power is Clicks
	public void bodyPowerUpgrade1()
    {
		if(cultivation >= bodyUpgradeCost)
        {
			bodyUpgradeLevel++;
			cultivation -= bodyUpgradeCost;
			bodyUpgradeCost *= 1.15;
			cultivationPowerValue++;
		}

	}
	//Realms increase Cultivation Per Second
	public void realmCultivationUpgrade1()
	{
		if (cultivation >= realmUpgradeCost)
		{
			realmUpgradeLevel++;
			cultivation -= realmUpgradeCost;
			realmUpgradeCost *= 1.15;
		}

	}
	//Souls Increase More Cultivation
	public void soulUpgrade1()
	{
		if (cultivation >= soulUpgradeCost)
		{
			soulLevel++;
			cultivation -= soulUpgradeCost;
			soulUpgradeCost *= 1.15;
		}

	}
}
