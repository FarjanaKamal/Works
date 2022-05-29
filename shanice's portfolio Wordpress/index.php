<?php
get_header();?>
<main role="main">
<h1 class="page-banner__title">PERSONAL PROJECTS</h1>
<p align="center">Here's a portfolio of my current and past projects.</p>
<p>
  <?php
    while(have_posts()){
      the_post();?>
      <h3><a id="title_link" href="<?php the_permalink();?>"><?php the_title(); ?></a></h3>
    <?php
     the_content();
   }?>
<?php
  echo paginate_links();
?>
</p>
</main>
</div>
<?php get_footer();?>
