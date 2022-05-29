<?php
get_header();?>
<main role="main">
<h1 class="page-banner__title">PERSONAL PROJECTS</h1>
<p>
  <?php
    while(have_posts()){
      the_post();?>
      <h2><a class="metabox__blog-home-link" href="<?php echo site_url('/blog')?>"><i class="fa fa-home" aria-hidden="true"></i> Back to Personal Projects </a></h2>
      <h4><?php the_title();?></h4>
    <?php
     the_content();
   }?>
</main>
</div>
<?php get_footer();?>
