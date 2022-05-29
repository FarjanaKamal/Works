<?php
function personal_website_files(){
    //1.1 is the Version
    //true means first css will load then js will load
    wp_enqueue_style('google-fonts','//fonts.googleapis.com/css?family=Asap|Comfortaa|Gudea|Hind+Guntur|Hind+Madurai|Hind+Vadodara|Maven+Pro|Ropa+Sans|Source+Code+Pro');
    wp_enqueue_style('font-awesome','//maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css');
    //Add action this function to folder and look for styles
    //first parameter: is the nickname
    //get_stylesheet_uri(): will go search the style css and will load into header
    wp_enqueue_style('style',get_stylesheet_uri());
}

add_action('wp_enqueue_scripts','personal_website_files');
//The function tells  the wordpress to go and do the jobs
//first parameter: it will go and search for any scripts
//second parameter: name
//function personal_website_features(){
  //for every page it will add title tag
  //  add_theme_support('title-tag');
//}
//add_action('after_setup_theme','personal_website_features');

//function to modify default WordPress query
function wpb_custom_query( $query ) {
  // Set parameters to modify the query
        $query->set( 'orderby', 'date' );
        $query->set( 'order', 'ASC' );
        $query->set( 'suppress_filters', 'true' );
}
// Hook our custom query function to the pre_get_posts
add_action( 'pre_get_posts', 'wpb_custom_query' );
?>
