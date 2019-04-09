JoeLawM's Humanity Mod
=============
Current Build: 1.03 exile
--------------------------
Working: No.
--------------------------
Descritpion
--------------------------
This is made for 1.03 exile mod, I don't like respect but humanity is tons of fun :) love you devs! 

Installation
--------------------------

* Download [`HumanitySystem`](https://github.com/)
* Copy **JoeHumanity** folder into your mission PBO.
* Open your **config.cpp** in your mission PBO.
* Look for:
```
class CfgExileCustomCode 
{
```
* Add this Below:
```
// Joe's Humanity System
#include "JoeHumanity\ExileClient_gui_xm8_slide_apps_onOpen"
#include "JoeHumanity\ExileServer_object_player_event_onMpKilled"
```
* Look for:
```
class CfgTraderCategories 
{
```
* Add this below:
```
	
	// Humanity System - By Joe
	#include "JoeHumanity\cfg\traders\Hero\TraderCategoriesHero.hpp" // Hero 
	#include "JoeHumanity\cfg\traders\Bandit\TraderCategoriesBandit.hpp" // Bandit


```
* Look for:
```
class Exile_Trader_CommunityCustoms
	{
		name = "COMMUNITY";
		showWeaponFilter = 0;
		categories[] = 
		{
			"Community"
		};
	};

	class Exile_Trader_CommunityCustoms2
	{
		name = "COMMUNITY";
		showWeaponFilter = 0;
		categories[] = 
		{
			"Community2"
		};
	};
```
* Replace it with:
```

	// Humanity System - By Joe
	#include "JoeHumanity\traders\Hero\TraderHero.hpp" // Hero 
	#include "JoeHumanity\traders\Bandit\TraderBandit.hpp" // Bandit 

```
* Open your **exile_server_config.pbo\config.cpp**
* Look for:
```
///////////////////////////////////////////////////////////////////////
// KILLFEED MAN!
///////////////////////////////////////////////////////////////////////
```
* Add this above:
```
	
	///////////////////////////////////////////////////////////////////////
	// HUMANITY (Humanity System By GR8)
	///////////////////////////////////////////////////////////////////////
	class Humanity
	{
		/**
		 * Humanity Gain Loss of kills
		 *
		 * Combination of different types of Kills
		 * Left Side of the X is killer
		 * and the Right side of the X is victim
		 */
		class Frags
		{
			SurvivorXSurvivor = -250; // Survivor Kills a Survivor
			SurvivorXHero = -500; // Survivor kills a Hero
			SurvivorXBandit = 500; // Survivor Kills a Bandit

			HeroXSurvivor = -750; // Hero Kills a Survivor
			HeroXHero = -500; // Hero kills a Hero
			HeroXBandit = 1000; // Hero Kills a Bandit

			BanditXSurvivor = -250; // Bandit Kills a Survivor
			BanditXHero = -1000; // Bandit kills a Hero
			BanditXBandit = 500; // Bandit Kills a Bandit
		};
		class Handcuffs 
		{
			trapping = -50;					// A handcuffs B
			breakingFree = 100; 			// B broke free
			releasedByHero = 100; 			// C releases B
			releasedByHostageTaker = 50; 	// A releases B	
		};
	};
