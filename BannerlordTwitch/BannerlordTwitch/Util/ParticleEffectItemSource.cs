﻿using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace BannerlordTwitch.Util
{
    public class OneShotParticleEffectItemSource : IItemsSource
    {
        public ItemCollection GetValues()
        {
            var items = new ItemCollection
            {
                {"psys_burning_projectile_default_coll", "Medium size explosion"},
                {"psys_burning_projectile_default_coll_small", "Small explosion"},
                {"psys_burning_projectile_stone_coll", "Medium size explosion - stones"},
                {"psys_burning_projectile_stone_coll_small", "Small explosion - stones"},
                {"psys_burning_projectile_water_coll", "Medium size explosion - water"},
                {"psys_burning_projectile_water_coll_small", "Small explosion - water"},
                {"psys_burning_projectile_wood_coll", "Medium size explosion - wood"},
                {"psys_burning_projectile_wood_coll_small", "Small explosion - wood"},
                {"psys_game_missile_default_coll", "Small poof of dust"},
                {"psys_game_stone_dust_a", "Small poof of dust"},
                {"psys_game_stone_water_coll", "Some splash like effect"},
                {"psys_game_water_splash_circular", "Some splash like effect with rings"},
            };
            return items;
        }
    }

    public class LoopingParticleEffectItemSource : IItemsSource
    {
        public ItemCollection GetValues()
        {
            var items = new ItemCollection
            {
                { "psys_torch_fire_moving", "Fire" },
                { "psys_bug_fly_1", "Yellow particles (healing effect)" },
                { "psys_campfire", "Stronger fire, not too much smoke" },
                { "psys_campfire_sparks", "Subtle sparks" },
                { "psys_game_blacksmith_flame", "Slow medium flames" },
                { "psys_game_burning_agent", "Effusing smoke and flames when moving" },
                { "psys_game_rain", "Rain further away" },
                { "psys_game_rain_close", "Rain on player" },
                { "psys_game_sparkle_b", "Very subtle small particles" },
                { "psys_torch_fire_moving", "Some fire" },
                { "psys_haze_1", "Black spooky smoke" },
                { "psys_adobe_battlement_destroyed", "Very dense smoke falling down" },
            };
            return items;
        }
        
        private static string[] pfx = {
            "psys_adobe_battlement_destroyed",
            "psys_battleground_env_fire",
            "psys_battleground_fire_small",
            "psys_blaze_1",
            "psys_blaze_1_light",
            "psys_blaze_on_wall",
            "psys_blaze_small_1",
            "psys_blaze_vertical_1",
            "psys_blaze_vertical_1_interior",
            "psys_blaze_vertical_1_medium",
            "psys_bug_fly_1",
            "psys_burning_projectile_default_coll",
            "psys_burning_projectile_default_coll_small",
            "psys_burning_projectile_stone_coll",
            "psys_burning_projectile_stone_coll_small",
            "psys_burning_projectile_water_coll",
            "psys_burning_projectile_water_coll_small",
            "psys_burning_projectile_wood_coll",
            "psys_burning_projectile_wood_coll_small",
            "psys_burning_woods_parts",
            "psys_burnt_wood_smoke",
            "psys_campaign_ballista_destruction",
            "psys_campaign_boulder_stone_coll",
            "psys_campaign_boulder_trail",
            "psys_campaign_clouds",
            "psys_campfire",
            "psys_campfire_sparks",
            "psys_cooking_smoke",
            "psys_dummy_smoke",
            "psys_dummy_straw",
            "psys_dust_env",
            "psys_dust_env_2",
            "psys_dust_env_3",
            "psys_dust_env_forest",
            "psys_dust_env_siege",
            "psys_env_snow_dust",
            "psys_fire_on_wall",
            "psys_fire_smoke_env_point",
            "psys_fire_smoke_env_square",
            "psys_fire_vertical",
            "psys_flue_smoke_tall",
            "psys_food_steam",
            "psys_game_ballista_destruction",
            "psys_game_ballista_trail",
            "psys_game_ballista_water_coll",
            "psys_game_ballista_weapon_destroy",
            "psys_game_ballistamissile_default_coll",
            "psys_game_ballistamissile_grass_coll",
            "psys_game_ballistamissile_metal_coll",
            "psys_game_ballistamissile_mud_coll",
            "psys_game_ballistamissile_sand_coll",
            "psys_game_ballistamissile_stone_coll",
            "psys_game_ballistamissile_wood_coll",
            "psys_game_batteringram_destruction",
            "psys_game_batteringram_door_hit",
            "psys_game_blacksmith_flame",
            "psys_game_blood_1",
            "psys_game_blood_2",
            "psys_game_blood_3",
            "psys_game_blood_4",
            "psys_game_blood_5",
            "psys_game_blood_6",
            "psys_game_blood_7",
            "psys_game_blood_sword_enter",
            "psys_game_blood_sword_exit",
            "psys_game_blood_sword_inside",
            "psys_game_boulder_default_coll",
            "psys_game_boulder_grass_coll",
            "psys_game_boulder_mud_coll",
            "psys_game_boulder_stone_coll",
            "psys_game_boulder_wood_coll",
            "psys_game_broken_arrow",
            "psys_game_burning_agent",
            "psys_game_burning_ballista_missile",
            "psys_game_burning_boulder_coll",
            "psys_game_burning_jar_trail",
            "psys_game_burning_projectile_stone_coll",
            "psys_game_cam_dust",
            "psys_game_campfire",
            "psys_game_castle_roof_destruction",
            "psys_game_dust_env_5",
            "psys_game_empty_particle",
            "psys_game_env_dust_4",
            "psys_game_env_dust_snow",
            "psys_game_hoof_default_col",
            "psys_game_hoof_default_col_s",
            "psys_game_hoof_dust",
            "psys_game_hoof_dust_2",
            "psys_game_hoof_dust_mud",
            "psys_game_hoof_dust_on_default",
            "psys_game_hoof_dust_on_grass",
            "psys_game_hoof_dust_on_stone",
            "psys_game_hoof_dust_snow",
            "psys_game_hoof_grass_col",
            "psys_game_hoof_grass_col_s",
            "psys_game_hoof_mud_col",
            "psys_game_hoof_mud_col_s",
            "psys_game_hoof_sand_col",
            "psys_game_hoof_sand_col_s",
            "psys_game_hoof_stone_col",
            "psys_game_hoof_stone_col_s",
            "psys_game_hoof_water_col_s",
            "psys_game_hoof_water_coll",
            "psys_game_infantry_default_col",
            "psys_game_infantry_grass_col",
            "psys_game_infantry_mud_col",
            "psys_game_infantry_sand_col",
            "psys_game_infantry_stone_col",
            "psys_game_infantry_water_coll",
            "psys_game_mangonel_trail",
            "psys_game_merlon_aserai_l1",
            "psys_game_merlon_aserai_l3",
            "psys_game_merlon_destruction",
            "psys_game_merlon_empire_l1",
            "psys_game_merlon_empire_l2",
            "psys_game_merlon_empire_l3",
            "psys_game_metal_metal_coll",
            "psys_game_metal_stone_coll",
            "psys_game_metal_wood_coll",
            "psys_game_missile_default_coll",
            "psys_game_missile_flame",
            "psys_game_missile_metal_coll",
            "psys_game_missile_mud_coll",
            "psys_game_missile_sand_coll",
            "psys_game_missile_stone_coll",
            "psys_game_missile_trail",
            "psys_game_missile_water_coll",
            "psys_game_missile_wood_coll",
            "psys_game_rain",
            "psys_game_rain_close",
            "psys_game_rain_splash",
            "psys_game_shield_break",
            "psys_game_shore_foam",
            "psys_game_siege_tower_destruction",
            "psys_game_snow",
            "psys_game_snow_2",
            "psys_game_sparkle_a",
            "psys_game_sparkle_b",
            "psys_game_step_dust_on_default",
            "psys_game_step_dust_on_grass",
            "psys_game_step_dust_on_sand",
            "psys_game_step_dust_on_stone",
            "psys_game_stone_default_coll",
            "psys_game_stone_dust_a",
            "psys_game_stone_gravel",
            "psys_game_stone_stone_coll",
            "psys_game_stone_water_coll",
            "psys_game_stone_wood_coll",
            "psys_game_water_splash_1",
            "psys_game_water_splash_2",
            "psys_game_water_splash_3",
            "psys_game_water_splash_circular",
            "psys_game_wood_dust_a",
            "psys_game_wood_splinter_a",
            "psys_game_wooden_barricade_destruction",
            "psys_game_wooden_merlon_destruction",
            "psys_haze_1",
            "psys_ladder_dust_10m",
            "psys_ladder_dust_12m",
            "psys_ladder_dust_14m",
            "psys_main_map_clouds",
            "psys_map_birds_a",
            "psys_mapicon_ballista_missile_trail",
            "psys_mapicon_boulder_stone_coll",
            "psys_mapicon_boulder_trail",
            "psys_mapicon_missile",
            "psys_mapicon_waterfall_circular_foam",
            "psys_missile_flame",
            "psys_mist_env_on_water",
            "psys_rain_dust",
            "psys_sea_foam_a",
            "psys_siege_door_falling_dust",
            "psys_siege_ledge_destruction",
            "psys_siege_sturgia_wall_destruction",
            "psys_siege_tower_falling_dust",
            "psys_smoke",
            "psys_smoke_flue_short",
            "psys_smoke_flue_tall",
            "psys_snow_camera_dust",
            "psys_snow_dust",
            "psys_snow_dust_env",
            "psys_stone_battlement_destroyed",
            "psys_torch_fire",
            "psys_torch_fire_moving",
            "psys_water_splash_circular_foam_copy0",
        };
    }
}