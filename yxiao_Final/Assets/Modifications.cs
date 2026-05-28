public class Modifications
{/*
    ░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ */


    /*  ================================================================
        GAUNTLET RUNNER
        ================================================================
        1 - directional light (colour, intensity, etc)
        modifications: changed color to D6E4FF, intensity to 1.2, 
                       shadow type to Hard Shadows, shadow strength to 0.8

        2 - fog
        modifications: color 6A537F, mode Exponential Squared, density 0.05

        3 - create & apply skybox and customise it (atmosphere thickness, sky tint, exposure, etc)
        modifications: sky tint color 6159D4, ground color 3E3B4C, atmosphere thickness 0.9,
                       exposure 0.55
        
        OBSTACLE PREFAB
        4 - add or modify light component (colour, range, intensity, etc)
        modifications: removed Light component from Cone Prefab,
                       added Point Light as child GameObject,
                       colour AF5414, range 9, intensity 2.5
        
        POWERUP PREFAB
        5 - replace with a new complex object comprised of 3 or more shapes (different from previously made object)
        modifications: replaced with a new Clock prefab (time-themed to match its function),
                       built from 2 cylinders as the face and frame, 
                       multiple cubes forming the number markers and hands, 
                       and a capsule as the center dot

        6 - use gameobject hierarchy to keep the powerup prefab organised
        [no record necessary]

        7 - apply at least 2 new textures
        (add source url or package name)
        texture source 1: Clock Frame https://ambientcg.com/view?id=Metal028
        texture source 2: Clock Face https://ambientcg.com/view?id=Marble012

        8 - add particle system component and customise at least 3 parameters
        parameter 1: Start Lifetime: 0.4
        parameter 2: Start Speed: 2
        parameter 3: Start Size: 0.4
        parameter 4: Start Color: FEFEFA
        parameter 5: Render Mode: Vertical Billboard
        parameter 6: Shape: Cone, angle 2, radius 0.17


        WALL
        9 - convert a wall to prefab, create a variant, and use the variant to replace the other wall in the scene
        [no record necessary]

        10 - modify wall prefab material tint so that the 2 walls are different in appearance or colour
        [no record necessary]
     
     */


}