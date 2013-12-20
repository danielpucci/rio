# Set this to the root of your project when deployed:
http_path = "/"
css_dir = "Content/Styles"
sass_dir = "Content/Styles/Source"
images_dir = "Content/Images"
javascripts_dir = "Content/Scripts"

# Set image path only
http_images_path = (environment == :production) ? '/' + images_dir : '/' + images_dir

# Set environment
environment = :development

# output_style = :expanded or :nested or :compact or :compressed
output_style = (environment == :production) ? :compressed : :expanded

# Others
relative_assets = true
preferred_syntax = :sass