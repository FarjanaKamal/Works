<?php
get_header();
// the page.php powers the pages inside worldpress
while (have_posts()){
    the_post(); ?>
    <main role="main">
      <h1 class="page-banner__title"><?php the_title();?></h1>
      <p align="center">
      <?php the_content ();?>
      </p>
    </main>
  </div>
<?php }
 get_footer();
?>
