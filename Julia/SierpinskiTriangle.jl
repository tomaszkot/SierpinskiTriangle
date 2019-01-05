using Luxor

width  = 1000;
height = 1000;
demo = Movie(width, height, "test")
global x = rand(1:width);
global y = rand(1:height);

points = [];

t = Turtle(
0,#X
0,#y
true,#pendown
0,#orientation
(1., 0., 0.)#pencolor, rgb, r = 1, so it's red
);

function backdrop(scene, framenumber)
    background("yellow")
end

function frame(scene, framenumber)
    sethue("black")

    #str = string("frame $framenumber of $(scene.framerange.stop) x=$(x) y=$(y)  points=$(points)")
    #text(str, Point(O.x, O.y-190), halign=:center)

    for l in 1:150

        v = rand(1:3);
        if v == 1
            global x /= 2;
            global y /= 2;
        elseif v == 2
            global x = width/2 + (width/2 - x)/2;
            global y = height - (height - y)/2;
        else
            global x = width - (width - x)/2;
            global y = y / 2;
        end

        push!(points, (x,y));
    end

    for pt in points
        Reposition(t, pt[1]-width/2, height-pt[2]);

        Circle(t, 3);
    end
end

animate(demo, [
    Scene(demo, backdrop, 0:20),
    Scene(demo, frame, 0:20, easingfunction=easeinoutcubic)
    ],
    creategif=false)
