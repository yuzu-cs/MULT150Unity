/*_____                       _____      _ _   _      
 / ____|                     / ____|    (_) | (_)     
| |  __  __ _ _ __ ___   ___| |     _ __ _| |_ _  ___ 
| | |_ |/ _` | '_ ` _ \ / _ \ |    | '__| | __| |/ __|
| |__| | (_| | | | | | |  __/ |____| |  | | |_| | (__ 
 \_____|\__,_|_| |_| |_|\___|\_____|_|  |_|\__|_|\___|
 * 
 * ► Is the game too easy or hard?
 *   a: The original game is fairly easy because the player can literally stay where they are from the beginning 
 *      and just wait for all the goals to be solved automatically purely by luck. 
 *      The chaos ball doesn't really cause too much chaos. Instead, it energizes the colored balls to make it
 *      easier for them to get to their goals
 *   
 * ► What would make it easier or harder?
 *   a: It would be harder if the goal is only solved when it is a straight hit from the bumper. Also, if the 
 *      chaos ball does something like drawing damages to the player etc., this would also be harder.
 *   
 * ► What would give it a “wow” factor?
 *   a: The chaos ball isn't really chaotic enough. If it does more damages or causes more chaos, or if it gets 
 *      a more interesting look, it will be a "wow" factor probably. 
 *      If we can alter the speed and viewing angle/depth of the player, the gameplay can be more fun too.
 *      
 * ► What parts of the game are fun? What parts of the game are tedious?
 *   a: I like the physics and collision. The fact that they are bouncing off one another randomly is both complex
 *      and fun. 
 *      One tedious part I obviously found is that the player can't do a lot in this game.
 *   
 *   
 *   
 *   
 * ==============================================================================
 * 1: Changed Footstep Sounds to Water Footsteps
 *       
 *      Added a Walking in Water.ogg to the Audio folder. In the FPSController, replaced the original footstep audio with this new water sound.
 *      The player now hears water splashing sounds when walking, which improves immersion and fits the scene theme
 *      
 * ==============================================================================
 * 2: Modified Player Bumper Shape
 * 
 *      Replaced the original bumper with a custom pickleball paddle shape, built from two Capsule objects and one Cylinder combined together. 
 *      Colors were adjusted to resemble a real pickleball paddle
 * 
 * ==============================================================================
 * 3: Added a Timer
 * 
 *      Added elapsedTime variable to track gameplay time. Timer runs during gameplay and stops when all goals are solved. 
 *      Current time shows on screen during gameplay, final time shows on the Game Over screen.
 *      
 * ==============================================================================
 * 4: Added Terrain Around Arena Border
 *  
 *      Added a Terrain surrounding the arena to cover the water and create a natural boundary. 
 *      Sculpted the terrain into hills and mountains around the edges, 
 *      and added palm tree and grass to enhance the visual environment.
 *      
 * ==============================================================================
 */