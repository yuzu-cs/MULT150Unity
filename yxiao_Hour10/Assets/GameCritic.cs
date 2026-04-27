/* 
 * ==============================================================================
 * 1: Changed Footstep Sounds to Water Footsteps
 *       
 *      Added a Walking in Water.ogg to the Audio folder. In the FPSController, replaced the original footstep audio with this new water sound.
 *      The player now hears water splashing sounds when walking, which improves immersion and fits the scene theme
 *      
 * ==============================================================================
 * 2: Modified Player Bumper Shape and Position
 * 
 *      Resized the player's bumper to (5.5, 2, 1) to make it longer and narrower. 
 *      Adjusted Position Y=1 to lift it off the ground so it appears as a floating board
 * 
 * ==============================================================================
 * 3: Added a Timer
 * 
 *      Added elapsedTime variable to track gameplay time. Timer runs during gameplay and stops when all goals are solved. 
 *      Current time shows on screen during gameplay, final time shows on the Game Over screen.
 *      
 * ==============================================================================
 * 
 */