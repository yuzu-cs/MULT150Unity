/* 
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