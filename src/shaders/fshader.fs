#version 330 core
out vec4 FragColor;
in vec2 TexCoord;
uniform sampler2D texture1;
uniform sampler2D texture2;
void main()
{
    FragColor = vec4(1.0f, 0.5f, 0.31f, 1.0f);
};

