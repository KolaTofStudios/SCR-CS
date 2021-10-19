/* -----------------------------------------------
/* How to use? : Check the GitHub README
/* ----------------------------------------------- */

/* To load a config file (particles.json) you need to host this demo (MAMP/WAMP/local)... */
/*
particlesJS.load('particles-js', 'particles.json', function() {
  console.log('particles.js loaded - callback');
});
*/

/* Otherwise just put the config content (json): */

particlesJS('particles-js',

  { particles: 
    { number: 
      { value: 250, density: 
        { enable: !0, value_area: 1200} 
      }, 
      color: 
      { value: ["#cc4141", "#f8c210", "#ffffff", "#33b1f8", "#931800", "#005fad", "#f9e884"] }, 
      move: {"speed":0.7},
      shape: { type: "circle", stroke: 
              { width: 0, color: "#fff" }, 
              polygon: { nb_sides: 5 }, 
              image: { src: "", width: 100, height: 100} 
            }, 
            opacity: { 
              value: 1, random: !1, anim: { enable: !1, speed: .5, opacity_min: .1, sync: !1} }, 
              size: { value: 3, random: !0, anim: { enable: !1, speed: 20, size_min: .3, sync: !1} }, 
              line_linked: { enable: !0, distance: 70, color: "#919191", opacity: .6, width: 1} }, 
              interactivity: { detect_on: "canvas", 
                  events: { onhover: { enable: false },
                   onclick: { enable: !1 }, resize: !0 }, 
                  modes: { bubble: { distance: 400, size: 40, duration: 2, opacity: 8, speed: 1 }, 
                  repulse: { distance: 200, duration: .4 }, 
                  push: { particles_nb: 4 }, 
                  remove: { particles_nb: 2}} }, 
                  retina_detect: !0 }

);