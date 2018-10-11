//
//  AppDelegate.m
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 05/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import "AppDelegate.h"
#import "NSObject+IntengineMovieDoc.h"
#include "MasterViewController.h"

@interface AppDelegate ()
@property (nonatomic, strong) IBOutlet MasterViewController *masterViewController;
@property (assign) IBOutlet NSWindow *window;
@end

@implementation AppDelegate

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification {
    self.masterViewController = [[MasterViewController alloc]
                                 initWithNibName:@"MasterViewController" bundle:nil];
    
    IntengineMovieDoc *movie1 = [[IntengineMovieDoc alloc] initWithTitle:@"The Godfather" rating:5 thumbImage:[NSImage imageNamed:@"TheGodfatherThumb.jpg"] fullImage:[NSImage imageNamed:@"TheGodfather.jpg"]];
    
    IntengineMovieDoc *movie2 = [[IntengineMovieDoc alloc] initWithTitle:@"Tree of Life" rating:4 thumbImage:[NSImage imageNamed:@"TreeOfLifeThumb.jpg"] fullImage:[NSImage imageNamed:@"TreeOfLife.jpg"]];
    
    IntengineMovieDoc *movie3 = [[IntengineMovieDoc alloc] initWithTitle:@"Taxi Driver" rating:5 thumbImage:[NSImage imageNamed:@"TaxiDriverThumb.jpg"] fullImage:[NSImage imageNamed:@"TaxiDriver.jpg"]];
    
    NSMutableArray *movies = [NSMutableArray arrayWithObjects: movie1, movie2, movie3, nil];
    self.masterViewController.movies = movies;
    
    [self.window.contentView addSubview:self.masterViewController.view];
    self.masterViewController.view.frame = ((NSView*)self.window.contentView).bounds;
}

- (void)applicationWillTerminate:(NSNotification *)aNotification {
    // Insert code here to tear down your application
}
@end
