<!DOCTYPE html>
<html lang="en">
<head>
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta  charset="<?php bloginfo('charset');?>">
  <?php
  wp_head();
  ?>
	<title>welcome to cyberspace</title>
</head>
<body>
		<div class="hero">
			<h1>shanice's portfolio</h1>
			<h2>take a step into my world</h2>
		</div>
    	<div class="container">
    <header>
		<nav>
      <a href="<?php echo site_url();?>" class="button">homepage</a>
			<a href="<?php echo site_url('/about-shanice'); ?>" class="button">about shanice</a>
      <a href="<?php echo site_url('/resume');?> " class="button">resume</a>
      <a href="<?php echo site_url('/blog');?>" class="button">personal projects</a>
      <a href="<?php echo site_url('/contact-me'); ?>" class="button">contact me</a>
		</nav>
    </header>
