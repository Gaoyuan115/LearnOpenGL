#version 330 core 
out vec4 FragColor;

uniform vec4 outColor;
uniform sampler2D ourTexture;

in vec4 vertexColor;
in vec2 texCoord;

void main()
{
   FragColor = texture(ourTexture, texCoord);
   //FragColor = vec4(texCoord.x, texCoord.x, texCoord.x, texCoord.x);
    //FragColor = vertexColor;
  //  FragColor = vec4(1.0, 1.0,1.0,1.0);

}
