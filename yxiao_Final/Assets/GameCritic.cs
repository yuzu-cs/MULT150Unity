/* 
	                                                                                               
                                                        ,;      .,                                  .,
         .Gt                                          f#i      ,Wt j.         t           t        ,Wt
        j#W:            ..           ..       :     .E#t      i#D. EW,        Ej GEEEEEEELEj      i#D.
      ;K#f             ;W,          ,W,     .Et    i#W,      f#f   E##j       E#,,;;L#K;;.E#,    f#f  
    .G#D.             j##,         t##,    ,W#t   L#D.     .D#i    E###D.     E#t   t#E   E#t  .D#i   
   j#K;              G###,        L###,   j###t :K#Wfff;  :KW,     E#jG#W;    E#t   t#E   E#t :KW,    
 ,K#f   ,GD;       :E####,      .E#j##,  G#fE#t i##WLLLLt t#f      E#t t##f   E#t   t#E   E#t t#f     
  j#Wi   E#t      ;W#DG##,     ;WW; ##,:K#i E#t  .E#L      ;#G     E#t  :K#E: E#t   t#E   E#t  ;#G    
   .G#D: E#t     j###DW##,    j#E.  ##f#W,  E#t    f#E:     :KE.   E#KDDDD###iE#t   t#E   E#t   :KE.  
     ,K#fK#t    G##i,,G##,  .D#L    ###K:   E#t     ,WW;     .DW:  E#f,t#Wi,,,E#t   t#E   E#t    .DW: 
       j###t  :K#K:   L##, :K#t     ##D.    E#t      .D#;      L#, E#t  ;#W:  E#t   t#E   E#t      L#,
        .G#t ;##D.    L##, ...      #G      ..         tt       jt DWi   ,KK: E#t    fE   E#t       jt
          ;; ,,,      .,,           j                                         ,;.     :   ,;.         
                                                                                                      

1. Is the game too easy or hard?
a: it's a *simple* game but definitely not easy. The character moves too slowly now and
   feels a bit clumsy that could frustrate some players

2. What changes would you do to make it easier or harder?
a: I would increase the player's movement speed such that they can trigger the powerup
   and also avoid hitting the obstacles more easily. I would also increase the starting
   game time from 10s to maybe 20s

3. What would make the game more appealing?
a: if there are scene/environment changes like Temple Run, it could be much more appealing
   if there are more types of colliables in addition to obstacles and powerups, it would 
   definitely be more appealing

4. What parts of the game are fun?
a: I think the fun part is the powerup increases the time remaining as oppose to give you
   some other buffs like speed up or scores

5. What parts of the game are tedious?
a: There are only two types of colliables, and there's no need to jump to retrive a powerup
   or to avoid an obstacle.
	

+-+-+-+-+-+-+-+-+
|o|b|s|t|a|c|l|e|
+-+-+-+-+-+-+-+-+
I replaced the original obstacle with a "traffic cone", but there is no cone in Unity 3D Objects, 
so I stacked 9 cylinders and decreased the scale to mimic a cone shape.

Here are the textures applied:
- Red plastic texture: 
https://www.magnific.com/free-vector/red-grunge-background-with-splats-stains_10135341.htm#fromView=keyword&page=1&position=3&uuid=0bc9e501-d4ab-4dee-9e00-b86eb05b64dd&query=Red+plastic+texture

- White reflective texture:
https://www.magnific.com/free-vector/abstract-white-minimal-banner-neumorphic-style-backdrop_262938355.htm

+-+-+-+-+-+-+-+
|P|o|w|e|r|u|p|
+-+-+-+-+-+-+-+
I replaced the original powerup with a "star", because of the same issue I mentioned above, there 
is no cone in Unity 3D, I rotated two cubes and overlapped one another to make them into a star-like
polyhedron shape

Here are the particle system changes I made:
- Start Lifetime: 0.6
- Start Speed: 2
- Start Size: 0.5
- Start Color: yellow -> red (orange-ish)
- Shape: Cone (Angle: 25, Radius: 1)
- Renderer: Vertical Billboard

 */