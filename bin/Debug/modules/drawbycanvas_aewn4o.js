/**/_jsload2&&_jsload2('drawbycanvas', 'function Vg(a){this.M=a;this.tP={strokeweight:"lineWidth",strokecolor:"strokeStyle",fillcolor:"fillStyle",strokeopacity:"globalAlpha",fillopacity:"globalAlpha"};this.Mb="canvas"}Vg.prototype=new D.ny;var Wg=Vg.prototype;Wg.Yn=function(){if(!this.canvas||this.canvas&&!Ab(this.canvas)){var a=this.canvas=O("canvas");this.M.Mf().Ps.appendChild(a);a.style.position="absolute";a=a.getContext("2d");a.lineCap="round";a.lineJoin="round";a.save();this.$S(this.canvas)}return this.canvas}; Wg.je=function(a,b,c){if(a&&0!==b[0].length){var e=a.getContext("2d");this.ua(a);var f=parseInt(a.style.top),g=parseInt(a.style.left);e.beginPath();z.lc.Nb(b,function(a){if(0!==a.length){e.moveTo(a[0].x-g,a[0].y-f);for(var b=1,c=a.length;b<c;b++)e.lineTo(a[b].x-g,a[b].y-f)}});this.iQ(a,c);"dashed"===c.strokeStyle&&this.kQ(e,b,g,f,c)}}; Wg.kQ=function(a,b,c,e,f){var g=this;a.beginPath();z.lc.Nb(b,function(b){if(0!==b.length){for(var k=[],m=0,n=b.length;m<n;m++)k.push({x:b[m].x-c,y:b[m].y-e});a.strokeStyle=f.strokeColor||"#3a6bdb";g.jQ(a,k,{lineWidth:f.qc||5,interval:2*f.qc||10,lineLength:2*f.qc||10,strokeStyle:g.lR(a.strokeStyle,f.sd)})}})}; Wg.jQ=function(a,b,c){for(var c=c||{},e=c.dx||10,f=c.lineWidth||5,g=c.C3||10,c=c.strokeStyle||"#3a6bdb",i=b.length-1,k=0,m=g+e,n=0,o=0;o<i;o++)var q=b[o].x,v=b[o].y,w=b[o+1].x,y=b[o+1].y,n=n+Math.sqrt((w-q)*(w-q)+(y-v)*(y-v));if(n<g)a.strokeStyle=c,a.lineWidth=f,a.lineJoin="round",a.lineCap="round",a.beginPath(),a.moveTo(b[0].x,b[0].y),a.lineTo(b[i].x,b[i].y),a.stroke();else for(n=0;n<i;n++){var q=b[n].x,v=b[n].y,w=b[n+1].x,y=b[n+1].y,o=Math.sqrt((w-q)*(w-q)+(y-v)*(y-v))+k+g,A=m-Math.abs(k);if(k<= m){var B=parseInt(o/m),C=e*(w-q)/o,F=e*(y-v)/o;xMove=g*(w-q)/o;yMove=g*(y-v)/o;startX=q+A*(w-q)/o;startY=v+A*(y-v)/o;tailX=q+(g-Math.abs(k))*(w-q)/o;tailY=v+(g-Math.abs(k))*(y-v)/o;a.beginPath();a.strokeStyle=c;a.lineJoin="round";a.lineCap="round";a.lineWidth=f;E?a.moveTo(E,G):a.moveTo(q,v);0>=k&&a.lineTo(q,v);a.lineTo(tailX,tailY);a.moveTo(startX,startY);E=0;for(G=2*B;E<G;E++)if(E%2)startX+=C,startY+=F,a.moveTo(startX,startY);else{startX+=xMove;startY+=yMove;if(0>(w-startX)*xMove)break;a.lineTo(startX, startY)}a.stroke()}var k=parseInt(o-m*B)-g,E=w-Math.abs(k)*(w-q)/o,G=y-Math.abs(k)*(y-v)/o;n===i-1&&0<k&&(a.beginPath(),a.strokeStyle=c,q=w-k*(w-q)/o,leftY=y-k*(y-v)/o,k<=g?(a.moveTo(q,leftY),a.lineTo(w,y)):(a.moveTo(q,leftY),a.moveTo(q+xMove,leftY+yMove)),a.stroke())}}; Wg.lR=function(a,b){if(4===a.length)var c=parseInt(a.substr(1,1)+a.substr(1,1),16),e=parseInt(a.substr(2,1)+a.substr(2,1),16),f=parseInt(a.substr(3,1)+a.substr(3,1),16);else c=parseInt(a.substr(1,2),16),e=parseInt(a.substr(3,2),16),f=parseInt(a.substr(5,2),16);return c="rgba("+c+","+e+","+f+","+b+")"};Wg.setAttribute=function(a,b,c){if(a){var e=a.getContext("2d"),f=this.pq(b);try{e[f]=c}catch(g){}a.setAttribute("_"+b,c||"");e.save()}};Wg.pq=function(a){return this.tP[a]||a}; Wg.$S=function(a){var b=this.M,c=b.U.uw,e=b.width+2*c,f=b.height+2*c,g=-b.offsetX-c,b=-b.offsetY-c,c=a.getContext("2d"),i={strokeStyle:c.strokeStyle,fillStyle:c.fillStyle,globalAlpha:c.globalAlpha,lineWidth:c.lineWidth,lineCap:"round",lineJoin:"round"};a.setAttribute("width",e);a.setAttribute("height",f);for(var k in i)c[k]=i[k];c.save();a=a.style;a.top=b+"px";a.left=g+"px"};Wg.DP=function(a){a.clearRect(0,0,9999,9999)}; Wg.iQ=function(a,b){var c=a.getContext("2d");c.globalAlpha=a.getAttribute("_fillopacity");0!==c.globalAlpha&&a.getAttribute("_fillcolor")&&c.fill();c.globalAlpha=a.getAttribute("_strokeopacity");0!==c.globalAlpha&&(a.getAttribute("_strokecolor")&&"dashed"!==b.strokeStyle)&&c.stroke()};Wg.ua=function(a){var b=this.M,c=b.U.uw,e=-b.offsetX-c,a=a.style;a.top=-b.offsetY-c+"px";a.left=e+"px"};D.nO=Vg; ');